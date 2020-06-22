using System;
using System.Numerics;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;

namespace Krzywe
{
    abstract public class CurveAbstract : INotifyPropertyChanged
    {
        //protected Vector2 StartingPoint;
        public BindingList<Vector2> Vectors;
        protected List<PointF> PointsToDraw;
        internal PointF CurrentPoint; //for add
        private Color color { set; get; }
        private int curveThickness;
        private int controlPointsThickness;
        private string name;
        private bool displayCurve = true;
        private bool displayControlPoints = true;
        private bool displayConvexHull = false;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string PropertyName)
        {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }

        public int ControlPointsThickness
        {
            get { return controlPointsThickness; }
            set
            {
                controlPointsThickness = value;
                OnPropertyChanged("controlPointsThickness");

            }
        }
        public int CurveThickness
        {
            get { return curveThickness; }
            set
            {
                curveThickness = value;
                OnPropertyChanged("CurveThickness");

            }
        }

        public Color Color
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertyChanged("Color");

            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");

            }
        }

        public bool DisplayCurve
        {
            get { return displayCurve; }
            set
            {
                displayCurve = value;
                OnPropertyChanged("DisplayCurve");
            }
        }


        public bool DisplayControlPoints
        {
            get { return displayControlPoints; }
            set
            {
                displayControlPoints = value;
                OnPropertyChanged("DisplayControlPoints");
            }
        }


        public bool DisplayConvexHull
        {
            get { return displayConvexHull; }
            set
            {
                displayConvexHull = value;
                OnPropertyChanged("DisplayConvexHull");
            }
        }

        protected CurveAbstract(BindingList<Vector2> Vectors, Color color, string name = "Krzywa", int controlPointsThickness=3, int curveThickness=1)
        {
            this.Vectors = Vectors ?? new BindingList<Vector2>();
            if(Vectors != null)
            {
                float x = 0f, y = 0f;
                foreach(Vector2 v in Vectors)
                {
                    x += v.X;
                    y += v.Y;
                }
                this.CurrentPoint = new PointF(x, y);
            }
            this.Vectors.ListChanged += VectorsListChangedEvent;
            this.color = color;
            this.name = name;
            this.controlPointsThickness = controlPointsThickness;
            this.curveThickness = curveThickness;
        }

        public abstract void VectorsListChangedEvent(object sender, ListChangedEventArgs e);

        public void DrawCurve(Graphics g)
        {
            g.DrawCurve(new Pen(this.Color, this.CurveThickness), PointsToDraw.ToArray());
        }

        public void DrawControlPoints(Graphics g, Pen pen)
        {
            Color OldColor = pen.Color;
            float th = pen.Width;
            pen.Width = controlPointsThickness;
            pen.Color = color;
            Brush brush = new SolidBrush(color);
            FontFamily ff = new FontFamily("Arial");
            Font font = new Font(ff, 10);
            Point p = new Point(0, 0);// Point.Round(new PointF(StartingPoint.X, StartingPoint.Y));
                                      //g.DrawEllipse(pen, new Rectangle(p.X - controlPointsThickness / 2, p.Y - controlPointsThickness / 2, controlPointsThickness, controlPointsThickness));

            int i = 1;
            foreach(Vector2 V in Vectors)
            {
                p.X += Convert.ToInt32(V.X);
                p.Y += Convert.ToInt32(V.Y);
                g.DrawEllipse(pen, new Rectangle(p.X - controlPointsThickness / 2, p.Y - controlPointsThickness / 2, controlPointsThickness, controlPointsThickness));
                g.DrawString(i.ToString(), font, brush, p);
                i++;
            }
            pen.Color = OldColor;
            pen.Width = th;
        }

        public virtual void AddControlPoint(Point P)
        {
            if(Vectors.Count > 0)
            {
                Vectors.Add(new Vector2(P.X - CurrentPoint.X, P.Y - CurrentPoint.Y));
            }
            else
            {
                Vectors.Add(new Vector2(P.X, P.Y));
            }
            this.CurrentPoint = P;
        }

        //TODO usuwanie dla krzywych sklejanych nie ma za dużo sensu
        public void RemoveControlPoint(Int32 PointPosition)
        {
            if(PointPosition < Vectors.Count - 1)
            {
                Vectors[PointPosition + 1] += Vectors[PointPosition];
            }
            Vectors.RemoveAt(PointPosition);
        }

        internal void Translate(string xS, string yS)
        {
            float x = float.Parse(xS);
            float y = float.Parse(yS);

            if (Vectors.Count > 0)
            {
                Vectors[0] += new Vector2(x, y);
            }
        }

        internal void Rotate(string text)
        {
            double angle = double.Parse(text) * 0.0174533;
            float s = (float) Math.Sin(angle);
            float c = (float) Math.Cos(angle);

            if(Vectors.Count < 2)
            {
                return;
            }

            Vector2 cPoint = new Vector2(0, 0);
            Vector2 prevPoint = new Vector2(0, 0);

            for (int i = 1; i < Vectors.Count; i++)
            {
                cPoint += Vectors[i];
                float xnew = cPoint.X * c - cPoint.Y * s;
                float ynew = cPoint.X * s + cPoint.Y * c;
                Vectors[i] = new Vector2(xnew, ynew) - prevPoint;
                prevPoint += Vectors[i];
            }
        }

        internal abstract Tuple<CurveAbstract, CurveAbstract> Split(string splitValue);
    }
}
