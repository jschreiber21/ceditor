using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Numerics;

namespace Krzywe
{
    public partial class Form1 : Form
    {
        Pen pen;
        Graphics g;
        State state;
        BindingList<CurveAbstract> Curves;
        int SelectedCurve;
        int SelectedVector;

        public Form1()
        {
            InitializeComponent();
            g = CanvasPanel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            state = State.DRAW;
            Curves = new BindingList<CurveAbstract>();
            curvesList.DataSource = Curves;
            curvesList.DisplayMember = "Name";
            pointsListBox.SelectionMode = SelectionMode.MultiSimple;
            curveTypeSelectionBox.DataSource = System.Enum.GetValues(typeof(CurveType));
            curveTypeSelectionBox.SetSelected(0, true);
        }

        private void ColorBox_OnClickEvent(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            Curves[SelectedCurve].Color = p.BackColor;
            Draw();
        }

        private void CanvasPanel_Paint(object sender, PaintEventArgs e)
        {
            Draw();

        }

        private void Draw()
        {
            g.Clear(Color.White);
            //TODO krzywa kontrolna i otoczka wypukła
            foreach (CurveAbstract curve in Curves)
            {
                if (curve.DisplayControlPoints)
                {
                    curve.DrawControlPoints(g, pen);
                }
            }

            foreach (CurveAbstract curve in Curves)
            {
                if (curve.DisplayCurve && curve.Vectors.Count > 0)
                {
                    curve.DrawCurve(g);
                }
            }
        }

        private void EditionMode_OnClickEvent(object sender, EventArgs e)
        {
            if (State.EDIT.Equals(state)) {
                return;
            }
            state = State.EDIT;
            //TODO lock/unlock buttons
        }

        private void NewCurve_OnClickEvent(object sender, EventArgs e)
        {
            Curves.Add(new CurveBuilder().ForCurveType((CurveType)curveTypeSelectionBox.SelectedItem).ForColor(Color.Black).Build());
/*            if (State.DRAW.Equals(state)) {
                return;
            }*/
            state = State.DRAW;
            curvesList.ClearSelected();
            curvesList.SetSelected(Curves.Count - 1, true);
        }


        private void copyCurveButton_Click(object sender, EventArgs e)
        {
            if(SelectedCurve < 0 || SelectedCurve >= Curves.Count)
            {
                return;
            }
            CurveAbstract ca = Curves[SelectedCurve];
            Curves.Add(new CurveBuilder().ForCurveType(Util.getCurveType(ca)).ForColor(ca.Color).ForVectorList(ca.Vectors).Build());
        }

        private void DiscardCurve_OnClickEvent(object sender, EventArgs e)
        {
            if (SelectedCurve < Curves.Count)
            {
                Curves.RemoveAt(SelectedCurve);
                SelectedCurve = Math.Min(SelectedCurve, Curves.Count - 1);
                Draw();
            }
        }

        private void CanvasPanel_OnClickEvent(object sender, EventArgs e)
        {

        }

        private void CanvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            switch (state)
            {
                case State.DRAW:
                    {
                        if (Curves.Count != 0)
                        {
                            Curves[SelectedCurve].AddControlPoint(e.Location);
                        }
                        break;
                    }
                case State.EDIT:
                    {

                    }
                    break;
                default:
                    break;
            }
            Draw();
        }

        private void EditCurveModePictureBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.EditCurveModePictureBox, "Tryb edycji");
        }


        private void curvesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (curvesList.SelectedIndex == -1)
            {
                return;
            }
            SelectedCurve = curvesList.SelectedIndex;
            nameTextBox.DataBindings.Clear();
            nameTextBox.DataBindings.Add("Text", Curves[SelectedCurve], "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            curveThicknessTextBox.DataBindings.Clear();
            curveThicknessTextBox.DataBindings.Add("Text", Curves[SelectedCurve], "CurveThickness", false, DataSourceUpdateMode.OnPropertyChanged);
            controlPointsThicknessTextBox.DataBindings.Clear();
            controlPointsThicknessTextBox.DataBindings.Add("Text", Curves[SelectedCurve], "ControlPointsThickness", false, DataSourceUpdateMode.OnPropertyChanged);
            displayCurveCheckBox.DataBindings.Clear();
            displayCurveCheckBox.DataBindings.Add("Checked", Curves[SelectedCurve], "DisplayCurve", false, DataSourceUpdateMode.OnPropertyChanged);
            displayControlPointsCheckBox.DataBindings.Clear();
            displayControlPointsCheckBox.DataBindings.Add("Checked", Curves[SelectedCurve], "DisplayControlPoints", false, DataSourceUpdateMode.OnPropertyChanged);
            displayConvexHullCheckBox.DataBindings.Clear();
            displayConvexHullCheckBox.DataBindings.Add("Checked", Curves[SelectedCurve], "DisplayConvexHull", false, DataSourceUpdateMode.OnPropertyChanged);
            pointsListBox.DataSource = Curves[SelectedCurve].Vectors;
            pointsListBox.DisplayMember = "ToString";
            Draw();
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Curves[SelectedCurve].Translate(moveXTextBox.Text, moveYTextBox.Text);
            }
            catch (Exception ex)
            {
                if (ex is ArgumentNullException || ex is FormatException || ex is OverflowException)
                {
                    errorBox.Text = "Wpisz wartość typu int w oba pola";
                }
            }
            Draw();
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Curves[SelectedCurve].Rotate(rotateTextBox.Text);
            }
            catch (Exception ex)
            {
                if (ex is ArgumentNullException || ex is FormatException || ex is OverflowException)
                {
                    errorBox.Text = "Wpisz wartość typu double";
                }
            }
            Draw();
        }

        private void swapPointsButton_Click(object sender, EventArgs e)
        {
            int no = pointsListBox.SelectedIndices.Count;
            if (no != 2)
            {
                errorBox.Text = "Select exactly two points";
                return;
            }
            int i1 = pointsListBox.SelectedIndices[0];
            int i2 = pointsListBox.SelectedIndices[1];
            Util.swap(Curves[SelectedCurve].Vectors, i1, i2);
            pointsListBox.ClearSelected();
            pointsListBox.SetSelected(i1, true);
            pointsListBox.SetSelected(i2, true);
            Draw();
        }

        private void pointUpButton_Click(object sender, EventArgs e)
        {
            int no = pointsListBox.SelectedIndices.Count;
            int i = pointsListBox.SelectedIndex;
            if (no != 1 || i == 0)
            {
                return;
            }
            Util.moveVectorUp(Curves[SelectedCurve].Vectors, i);
            pointsListBox.SetSelected(i, false);
            pointsListBox.SetSelected(i - 1, true);
            Draw();
        }

        private void pointDownButton_Click(object sender, EventArgs e)
        {
            int no = pointsListBox.SelectedIndices.Count;
            int i = pointsListBox.SelectedIndex;
            if (no != 1 || i == no - 2)
            {
                return;
            }
            Util.moveVectorUp(Curves[SelectedCurve].Vectors, i + 1);
            pointsListBox.SetSelected(i, false);
            pointsListBox.SetSelected(i + 1, true);
            Draw();
        }

        private void deletePointButton_Click(object sender, EventArgs e)
        {
            int no = pointsListBox.SelectedIndices.Count;
            int i = pointsListBox.SelectedIndex;
            if (no != 1)
            {
                errorBox.Text = "Wybierz dokładnie jeden punkt";
                return;
            }
            Curves[SelectedCurve].RemoveControlPoint(i);
            Draw();
        }

        private void splitButton_Click(object sender, EventArgs e)
        {
            try
            {
                Tuple<CurveAbstract, CurveAbstract> curves = Curves[SelectedCurve].Split(splitTextBox.Text);
                Curves.RemoveAt(SelectedCurve);
                Curves.Add(curves.Item1);
                Curves.Add(curves.Item2);
                SelectedCurve = Curves.Count - 2;
                Draw();
            }
            catch (Exception ex)
            {
                if (ex is ArgumentNullException || ex is FormatException || ex is OverflowException)
                {
                    errorBox.Text = "Wpisz wartość typu double";
                }
                if(ex is NotImplementedException)
                {
                    errorBox.Text = "Podział nie jest dostępny dla tego typu krzywej";
                }
            }
            Draw();
        }
        private void showPointButton_Click(object sender, EventArgs e)
        {
            try
            {
                PointF point = Horner.getBezierValue(Util.Vector2toPoints(Curves[SelectedCurve].Vectors), float.Parse(splitTextBox.Text));
                Draw();
                Color c = pen.Color;
                pen.Color = Color.Crimson;
                g.DrawEllipse(pen, new Rectangle(Convert.ToInt32(point.X) - 2, Convert.ToInt32(point.Y) - 2, 4, 4));
                pen.Color = c;
            }
            catch (Exception ex)
            {
                if (ex is ArgumentNullException || ex is FormatException || ex is OverflowException)
                {
                    errorBox.Text = "Wpisz wartość typu double";
                }
                if (ex is NotImplementedException)
                {
                    errorBox.Text = "Podział nie jest dostępny dla tego typu krzywej";
                }
            }
        }

        private void elevateButton_Click(object sender, EventArgs e)
        {
            List<Vector2> newPoints = DeCasteljau.ElevateDegree(Curves[SelectedCurve].Vectors);
            Curves[SelectedCurve].Vectors.ListChanged -= Curves[SelectedCurve].VectorsListChangedEvent;
            Curves[SelectedCurve].Vectors.Clear();
            foreach(Vector2 point in newPoints)
            {
                Curves[SelectedCurve].Vectors.Add(point);
            }
            Curves[SelectedCurve].Vectors.ListChanged += Curves[SelectedCurve].VectorsListChangedEvent;
            Draw();
        }
        private void decreaseButton_Click(object sender, EventArgs e)
        {
            if(Curves[SelectedCurve].Vectors.Count < 4)
            {
                errorBox.Text = "Krzywa musi mieć co najmniej 4 punkty kontrolne";
                return;
            }
            List<Vector2> newPoints = DeCasteljau.DecreaseDegree(Curves[SelectedCurve].Vectors);
            Curves[SelectedCurve].Vectors.ListChanged -= Curves[SelectedCurve].VectorsListChangedEvent;
            Curves[SelectedCurve].Vectors.Clear();
            foreach (Vector2 point in newPoints)
            {
                Curves[SelectedCurve].Vectors.Add(point);
            }
            Curves[SelectedCurve].Vectors.ListChanged += Curves[SelectedCurve].VectorsListChangedEvent;
            Draw();
        }

        private void pointsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int no = pointsListBox.SelectedIndices.Count;
            if(no != 1)
            {
                errorBox.Text = "Wybierz dokładnie jeden wektor";
                return;
            }
            SelectedVector = pointsListBox.SelectedIndex;
            editXBox.Text = Curves[SelectedCurve].Vectors[SelectedVector].X.ToString();
            editYBox.Text = Curves[SelectedCurve].Vectors[SelectedVector].Y.ToString();
            if(Curves[SelectedCurve].GetType() == typeof(RationalBezier))
            {
                editWBox.Text = ((RationalBezier)Curves[SelectedCurve]).weights[SelectedVector].ToString();
            }
            else
            {
                editWBox.Text = "";
            }
        }

        private void editPointButton_Click(object sender, EventArgs e)
        {
            int no = pointsListBox.SelectedIndices.Count;
            if (no != 1)
            {
                errorBox.Text = "Wybierz dokładnie jeden wektor";
                return;
            }
            if (Curves[SelectedCurve].GetType() == typeof(RationalBezier))
            {
                ((RationalBezier)Curves[SelectedCurve]).weights[SelectedVector] = float.Parse(editWBox.Text);
            }
            Curves[SelectedCurve].Vectors[SelectedVector] = new Vector2(float.Parse(editXBox.Text), float.Parse(editYBox.Text));

            Draw();
        }

        private void combineButton_Click(object sender, EventArgs e)
        {
            try
            {
                int first = int.Parse(combineFBox.Text);
                int second = int.Parse(combineSBox.Text);
                if (first == second || first >= Curves.Count || second >= Curves.Count)
                {
                    errorBox.Text = "Wybierz dwa różne indeksy krzywych";
                    return;
                }
                CurveAbstract combined = Combine.CombineG1(Curves[first], Curves[second]);
                Curves.RemoveAt(Math.Max(first, second));
                Curves.RemoveAt(Math.Min(first, second));
                Curves.Add(combined);
                curvesList.SetSelected(Curves.Count - 1, true);
                Draw();
            }
            catch (Exception ex)
            {
                if (ex is ArgumentNullException || ex is FormatException || ex is OverflowException)
                {
                    errorBox.Text = "Wpisz dwie wartości int";
                    return;
                }
            }
        }

    }
}
