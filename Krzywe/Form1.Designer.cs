namespace Krzywe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.curveManagementPanel = new System.Windows.Forms.Panel();
            this.copyCurveButton = new System.Windows.Forms.Button();
            this.NewCurveButton = new System.Windows.Forms.Button();
            this.deleteCurve = new System.Windows.Forms.Button();
            this.redColorPictureBox = new System.Windows.Forms.PictureBox();
            this.blueColorPictureBox = new System.Windows.Forms.PictureBox();
            this.blackColorPictureBox = new System.Windows.Forms.PictureBox();
            this.EditCurveModePictureBox = new System.Windows.Forms.PictureBox();
            this.greenColorPictureBox = new System.Windows.Forms.PictureBox();
            this.leftBarPanel = new System.Windows.Forms.Panel();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.curvePropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.combineButton = new System.Windows.Forms.Button();
            this.combineSBox = new System.Windows.Forms.TextBox();
            this.combineFBox = new System.Windows.Forms.TextBox();
            this.editWBox = new System.Windows.Forms.TextBox();
            this.editXBox = new System.Windows.Forms.TextBox();
            this.editYBox = new System.Windows.Forms.TextBox();
            this.editPointButton = new System.Windows.Forms.Button();
            this.decreaseButton = new System.Windows.Forms.Button();
            this.elevateButton = new System.Windows.Forms.Button();
            this.splitButton = new System.Windows.Forms.Button();
            this.splitTextBox = new System.Windows.Forms.TextBox();
            this.reversePointsButton = new System.Windows.Forms.Button();
            this.deletePointButton = new System.Windows.Forms.Button();
            this.pointDownButton = new System.Windows.Forms.Button();
            this.pointUpButton = new System.Windows.Forms.Button();
            this.swapPointsButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.rotateButton = new System.Windows.Forms.Button();
            this.pointsListBox = new System.Windows.Forms.ListBox();
            this.controlPointsThicknessTextBox = new System.Windows.Forms.TextBox();
            this.curveThicknessTextBox = new System.Windows.Forms.TextBox();
            this.displayConvexHullCheckBox = new System.Windows.Forms.CheckBox();
            this.displayControlPointsCheckBox = new System.Windows.Forms.CheckBox();
            this.displayCurveCheckBox = new System.Windows.Forms.CheckBox();
            this.rotateTextBox = new System.Windows.Forms.TextBox();
            this.moveXTextBox = new System.Windows.Forms.TextBox();
            this.moveYTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.curvesList = new System.Windows.Forms.ListBox();
            this.curveSelectorPanel = new System.Windows.Forms.Panel();
            this.curveTypeSelectionBox = new System.Windows.Forms.ListBox();
            this.errorBox = new System.Windows.Forms.TextBox();
            this.showPointButton = new System.Windows.Forms.Button();
            this.curveManagementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditCurveModePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColorPictureBox)).BeginInit();
            this.leftBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.curvePropertiesGroupBox.SuspendLayout();
            this.curveSelectorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.BackColor = System.Drawing.Color.White;
            this.CanvasPanel.Location = new System.Drawing.Point(50, 0);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(1000, 780);
            this.CanvasPanel.TabIndex = 0;
            this.CanvasPanel.Click += new System.EventHandler(this.CanvasPanel_OnClickEvent);
            this.CanvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CanvasPanel_Paint);
            this.CanvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel_MouseDown);
            // 
            // curveManagementPanel
            // 
            this.curveManagementPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.curveManagementPanel.Controls.Add(this.copyCurveButton);
            this.curveManagementPanel.Controls.Add(this.NewCurveButton);
            this.curveManagementPanel.Controls.Add(this.deleteCurve);
            this.curveManagementPanel.Location = new System.Drawing.Point(1450, 0);
            this.curveManagementPanel.Name = "curveManagementPanel";
            this.curveManagementPanel.Size = new System.Drawing.Size(400, 50);
            this.curveManagementPanel.TabIndex = 1;
            // 
            // copyCurveButton
            // 
            this.copyCurveButton.Location = new System.Drawing.Point(205, 12);
            this.copyCurveButton.Name = "copyCurveButton";
            this.copyCurveButton.Size = new System.Drawing.Size(90, 23);
            this.copyCurveButton.TabIndex = 30;
            this.copyCurveButton.Text = "Kopiuj krzywą";
            this.copyCurveButton.UseVisualStyleBackColor = true;
            this.copyCurveButton.Click += new System.EventHandler(this.copyCurveButton_Click);
            // 
            // NewCurveButton
            // 
            this.NewCurveButton.Location = new System.Drawing.Point(6, 12);
            this.NewCurveButton.Name = "NewCurveButton";
            this.NewCurveButton.Size = new System.Drawing.Size(90, 23);
            this.NewCurveButton.TabIndex = 28;
            this.NewCurveButton.Text = "Nowa krzywa";
            this.NewCurveButton.UseVisualStyleBackColor = true;
            this.NewCurveButton.Click += new System.EventHandler(this.NewCurve_OnClickEvent);
            // 
            // deleteCurve
            // 
            this.deleteCurve.Location = new System.Drawing.Point(102, 12);
            this.deleteCurve.Name = "deleteCurve";
            this.deleteCurve.Size = new System.Drawing.Size(97, 23);
            this.deleteCurve.TabIndex = 29;
            this.deleteCurve.Text = "Usuń krzywą";
            this.deleteCurve.UseVisualStyleBackColor = true;
            this.deleteCurve.Click += new System.EventHandler(this.DiscardCurve_OnClickEvent);
            // 
            // redColorPictureBox
            // 
            this.redColorPictureBox.BackColor = System.Drawing.Color.Red;
            this.redColorPictureBox.Location = new System.Drawing.Point(0, 70);
            this.redColorPictureBox.Name = "redColorPictureBox";
            this.redColorPictureBox.Size = new System.Drawing.Size(45, 45);
            this.redColorPictureBox.TabIndex = 8;
            this.redColorPictureBox.TabStop = false;
            this.redColorPictureBox.Click += new System.EventHandler(this.ColorBox_OnClickEvent);
            // 
            // blueColorPictureBox
            // 
            this.blueColorPictureBox.BackColor = System.Drawing.Color.Blue;
            this.blueColorPictureBox.Location = new System.Drawing.Point(51, 70);
            this.blueColorPictureBox.Name = "blueColorPictureBox";
            this.blueColorPictureBox.Size = new System.Drawing.Size(45, 45);
            this.blueColorPictureBox.TabIndex = 7;
            this.blueColorPictureBox.TabStop = false;
            this.blueColorPictureBox.Click += new System.EventHandler(this.ColorBox_OnClickEvent);
            // 
            // blackColorPictureBox
            // 
            this.blackColorPictureBox.BackColor = System.Drawing.Color.Black;
            this.blackColorPictureBox.Location = new System.Drawing.Point(102, 70);
            this.blackColorPictureBox.Name = "blackColorPictureBox";
            this.blackColorPictureBox.Size = new System.Drawing.Size(45, 45);
            this.blackColorPictureBox.TabIndex = 6;
            this.blackColorPictureBox.TabStop = false;
            this.blackColorPictureBox.Click += new System.EventHandler(this.ColorBox_OnClickEvent);
            // 
            // EditCurveModePictureBox
            // 
            this.EditCurveModePictureBox.Location = new System.Drawing.Point(0, 359);
            this.EditCurveModePictureBox.Name = "EditCurveModePictureBox";
            this.EditCurveModePictureBox.Size = new System.Drawing.Size(45, 45);
            this.EditCurveModePictureBox.TabIndex = 5;
            this.EditCurveModePictureBox.TabStop = false;
            this.EditCurveModePictureBox.Click += new System.EventHandler(this.EditionMode_OnClickEvent);
            this.EditCurveModePictureBox.MouseHover += new System.EventHandler(this.EditCurveModePictureBox_MouseHover);
            // 
            // greenColorPictureBox
            // 
            this.greenColorPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenColorPictureBox.Location = new System.Drawing.Point(153, 70);
            this.greenColorPictureBox.Name = "greenColorPictureBox";
            this.greenColorPictureBox.Size = new System.Drawing.Size(45, 45);
            this.greenColorPictureBox.TabIndex = 0;
            this.greenColorPictureBox.TabStop = false;
            this.greenColorPictureBox.Click += new System.EventHandler(this.ColorBox_OnClickEvent);
            // 
            // leftBarPanel
            // 
            this.leftBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.leftBarPanel.Controls.Add(this.EditCurveModePictureBox);
            this.leftBarPanel.Controls.Add(this.pictureBox16);
            this.leftBarPanel.Controls.Add(this.pictureBox15);
            this.leftBarPanel.Controls.Add(this.pictureBox14);
            this.leftBarPanel.Controls.Add(this.pictureBox13);
            this.leftBarPanel.Controls.Add(this.pictureBox12);
            this.leftBarPanel.Controls.Add(this.pictureBox11);
            this.leftBarPanel.Controls.Add(this.pictureBox10);
            this.leftBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftBarPanel.Location = new System.Drawing.Point(0, 0);
            this.leftBarPanel.Name = "leftBarPanel";
            this.leftBarPanel.Size = new System.Drawing.Size(50, 800);
            this.leftBarPanel.TabIndex = 2;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Location = new System.Drawing.Point(2, 53);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(45, 45);
            this.pictureBox16.TabIndex = 15;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(2, 104);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(45, 45);
            this.pictureBox15.TabIndex = 14;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(2, 155);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(45, 45);
            this.pictureBox14.TabIndex = 13;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(2, 206);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(45, 45);
            this.pictureBox13.TabIndex = 12;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(2, 257);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(45, 45);
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(2, 308);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(45, 45);
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(2, 2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(45, 45);
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            // 
            // curvePropertiesGroupBox
            // 
            this.curvePropertiesGroupBox.Controls.Add(this.showPointButton);
            this.curvePropertiesGroupBox.Controls.Add(this.combineButton);
            this.curvePropertiesGroupBox.Controls.Add(this.combineSBox);
            this.curvePropertiesGroupBox.Controls.Add(this.combineFBox);
            this.curvePropertiesGroupBox.Controls.Add(this.editWBox);
            this.curvePropertiesGroupBox.Controls.Add(this.editXBox);
            this.curvePropertiesGroupBox.Controls.Add(this.editYBox);
            this.curvePropertiesGroupBox.Controls.Add(this.editPointButton);
            this.curvePropertiesGroupBox.Controls.Add(this.decreaseButton);
            this.curvePropertiesGroupBox.Controls.Add(this.elevateButton);
            this.curvePropertiesGroupBox.Controls.Add(this.splitButton);
            this.curvePropertiesGroupBox.Controls.Add(this.splitTextBox);
            this.curvePropertiesGroupBox.Controls.Add(this.reversePointsButton);
            this.curvePropertiesGroupBox.Controls.Add(this.deletePointButton);
            this.curvePropertiesGroupBox.Controls.Add(this.pointDownButton);
            this.curvePropertiesGroupBox.Controls.Add(this.pointUpButton);
            this.curvePropertiesGroupBox.Controls.Add(this.swapPointsButton);
            this.curvePropertiesGroupBox.Controls.Add(this.moveButton);
            this.curvePropertiesGroupBox.Controls.Add(this.rotateButton);
            this.curvePropertiesGroupBox.Controls.Add(this.pointsListBox);
            this.curvePropertiesGroupBox.Controls.Add(this.controlPointsThicknessTextBox);
            this.curvePropertiesGroupBox.Controls.Add(this.curveThicknessTextBox);
            this.curvePropertiesGroupBox.Controls.Add(this.displayConvexHullCheckBox);
            this.curvePropertiesGroupBox.Controls.Add(this.displayControlPointsCheckBox);
            this.curvePropertiesGroupBox.Controls.Add(this.displayCurveCheckBox);
            this.curvePropertiesGroupBox.Controls.Add(this.rotateTextBox);
            this.curvePropertiesGroupBox.Controls.Add(this.moveXTextBox);
            this.curvePropertiesGroupBox.Controls.Add(this.moveYTextBox);
            this.curvePropertiesGroupBox.Controls.Add(this.nameTextBox);
            this.curvePropertiesGroupBox.Controls.Add(this.greenColorPictureBox);
            this.curvePropertiesGroupBox.Controls.Add(this.blackColorPictureBox);
            this.curvePropertiesGroupBox.Controls.Add(this.blueColorPictureBox);
            this.curvePropertiesGroupBox.Controls.Add(this.redColorPictureBox);
            this.curvePropertiesGroupBox.Location = new System.Drawing.Point(1450, 56);
            this.curvePropertiesGroupBox.Name = "curvePropertiesGroupBox";
            this.curvePropertiesGroupBox.Size = new System.Drawing.Size(400, 750);
            this.curvePropertiesGroupBox.TabIndex = 15;
            this.curvePropertiesGroupBox.TabStop = false;
            this.curvePropertiesGroupBox.Text = "Właściwości krzywej";
            // 
            // combineButton
            // 
            this.combineButton.Location = new System.Drawing.Point(319, 183);
            this.combineButton.Name = "combineButton";
            this.combineButton.Size = new System.Drawing.Size(75, 23);
            this.combineButton.TabIndex = 47;
            this.combineButton.Text = "Połącz";
            this.combineButton.UseVisualStyleBackColor = true;
            this.combineButton.Click += new System.EventHandler(this.combineButton_Click);
            // 
            // combineSBox
            // 
            this.combineSBox.Location = new System.Drawing.Point(271, 186);
            this.combineSBox.Name = "combineSBox";
            this.combineSBox.Size = new System.Drawing.Size(46, 20);
            this.combineSBox.TabIndex = 46;
            // 
            // combineFBox
            // 
            this.combineFBox.Location = new System.Drawing.Point(219, 186);
            this.combineFBox.Name = "combineFBox";
            this.combineFBox.Size = new System.Drawing.Size(46, 20);
            this.combineFBox.TabIndex = 45;
            // 
            // editWBox
            // 
            this.editWBox.Location = new System.Drawing.Point(323, 688);
            this.editWBox.Name = "editWBox";
            this.editWBox.Size = new System.Drawing.Size(46, 20);
            this.editWBox.TabIndex = 44;
            // 
            // editXBox
            // 
            this.editXBox.Location = new System.Drawing.Point(219, 688);
            this.editXBox.Name = "editXBox";
            this.editXBox.Size = new System.Drawing.Size(46, 20);
            this.editXBox.TabIndex = 43;
            // 
            // editYBox
            // 
            this.editYBox.Location = new System.Drawing.Point(271, 688);
            this.editYBox.Name = "editYBox";
            this.editYBox.Size = new System.Drawing.Size(46, 20);
            this.editYBox.TabIndex = 42;
            // 
            // editPointButton
            // 
            this.editPointButton.Location = new System.Drawing.Point(219, 714);
            this.editPointButton.Name = "editPointButton";
            this.editPointButton.Size = new System.Drawing.Size(90, 23);
            this.editPointButton.TabIndex = 41;
            this.editPointButton.Text = "Edytuj";
            this.editPointButton.UseVisualStyleBackColor = true;
            this.editPointButton.Click += new System.EventHandler(this.editPointButton_Click);
            // 
            // decreaseButton
            // 
            this.decreaseButton.Location = new System.Drawing.Point(219, 463);
            this.decreaseButton.Name = "decreaseButton";
            this.decreaseButton.Size = new System.Drawing.Size(140, 23);
            this.decreaseButton.TabIndex = 40;
            this.decreaseButton.Text = "Obniż stopień";
            this.decreaseButton.UseVisualStyleBackColor = true;
            this.decreaseButton.Click += new System.EventHandler(this.decreaseButton_Click);
            // 
            // elevateButton
            // 
            this.elevateButton.Location = new System.Drawing.Point(219, 434);
            this.elevateButton.Name = "elevateButton";
            this.elevateButton.Size = new System.Drawing.Size(140, 23);
            this.elevateButton.TabIndex = 39;
            this.elevateButton.Text = "Podnieś stopień";
            this.elevateButton.UseVisualStyleBackColor = true;
            this.elevateButton.Click += new System.EventHandler(this.elevateButton_Click);
            // 
            // splitButton
            // 
            this.splitButton.Location = new System.Drawing.Point(58, 241);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(75, 23);
            this.splitButton.TabIndex = 38;
            this.splitButton.Text = "Podziel";
            this.splitButton.UseVisualStyleBackColor = true;
            this.splitButton.Click += new System.EventHandler(this.splitButton_Click);
            // 
            // splitTextBox
            // 
            this.splitTextBox.Location = new System.Drawing.Point(6, 241);
            this.splitTextBox.Name = "splitTextBox";
            this.splitTextBox.Size = new System.Drawing.Size(46, 20);
            this.splitTextBox.TabIndex = 37;
            // 
            // reversePointsButton
            // 
            this.reversePointsButton.Location = new System.Drawing.Point(219, 394);
            this.reversePointsButton.Name = "reversePointsButton";
            this.reversePointsButton.Size = new System.Drawing.Size(90, 34);
            this.reversePointsButton.TabIndex = 36;
            this.reversePointsButton.Text = "Odwróć kolejność";
            this.reversePointsButton.UseVisualStyleBackColor = true;
            // 
            // deletePointButton
            // 
            this.deletePointButton.Location = new System.Drawing.Point(219, 365);
            this.deletePointButton.Name = "deletePointButton";
            this.deletePointButton.Size = new System.Drawing.Size(90, 23);
            this.deletePointButton.TabIndex = 35;
            this.deletePointButton.Text = "Usuń";
            this.deletePointButton.UseVisualStyleBackColor = true;
            this.deletePointButton.Click += new System.EventHandler(this.deletePointButton_Click);
            // 
            // pointDownButton
            // 
            this.pointDownButton.Location = new System.Drawing.Point(219, 336);
            this.pointDownButton.Name = "pointDownButton";
            this.pointDownButton.Size = new System.Drawing.Size(90, 23);
            this.pointDownButton.TabIndex = 34;
            this.pointDownButton.Text = "W dół";
            this.pointDownButton.UseVisualStyleBackColor = true;
            this.pointDownButton.Click += new System.EventHandler(this.pointDownButton_Click);
            // 
            // pointUpButton
            // 
            this.pointUpButton.Location = new System.Drawing.Point(219, 307);
            this.pointUpButton.Name = "pointUpButton";
            this.pointUpButton.Size = new System.Drawing.Size(90, 23);
            this.pointUpButton.TabIndex = 33;
            this.pointUpButton.Text = "W górę";
            this.pointUpButton.UseVisualStyleBackColor = true;
            this.pointUpButton.Click += new System.EventHandler(this.pointUpButton_Click);
            // 
            // swapPointsButton
            // 
            this.swapPointsButton.Location = new System.Drawing.Point(219, 278);
            this.swapPointsButton.Name = "swapPointsButton";
            this.swapPointsButton.Size = new System.Drawing.Size(90, 23);
            this.swapPointsButton.TabIndex = 32;
            this.swapPointsButton.Text = "Zamień";
            this.swapPointsButton.UseVisualStyleBackColor = true;
            this.swapPointsButton.Click += new System.EventHandler(this.swapPointsButton_Click);
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(110, 186);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(75, 23);
            this.moveButton.TabIndex = 31;
            this.moveButton.Text = "Przesuń";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // rotateButton
            // 
            this.rotateButton.Location = new System.Drawing.Point(58, 212);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(75, 23);
            this.rotateButton.TabIndex = 30;
            this.rotateButton.Text = "Obróć";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // pointsListBox
            // 
            this.pointsListBox.FormattingEnabled = true;
            this.pointsListBox.Location = new System.Drawing.Point(0, 278);
            this.pointsListBox.Name = "pointsListBox";
            this.pointsListBox.Size = new System.Drawing.Size(213, 459);
            this.pointsListBox.TabIndex = 27;
            this.pointsListBox.SelectedIndexChanged += new System.EventHandler(this.pointsListBox_SelectedIndexChanged);
            // 
            // controlPointsThicknessTextBox
            // 
            this.controlPointsThicknessTextBox.Location = new System.Drawing.Point(72, 42);
            this.controlPointsThicknessTextBox.Name = "controlPointsThicknessTextBox";
            this.controlPointsThicknessTextBox.Size = new System.Drawing.Size(46, 20);
            this.controlPointsThicknessTextBox.TabIndex = 26;
            // 
            // curveThicknessTextBox
            // 
            this.curveThicknessTextBox.Location = new System.Drawing.Point(6, 42);
            this.curveThicknessTextBox.Name = "curveThicknessTextBox";
            this.curveThicknessTextBox.Size = new System.Drawing.Size(46, 20);
            this.curveThicknessTextBox.TabIndex = 25;
            // 
            // displayConvexHullCheckBox
            // 
            this.displayConvexHullCheckBox.AutoSize = true;
            this.displayConvexHullCheckBox.Location = new System.Drawing.Point(184, 19);
            this.displayConvexHullCheckBox.Name = "displayConvexHullCheckBox";
            this.displayConvexHullCheckBox.Size = new System.Drawing.Size(66, 17);
            this.displayConvexHullCheckBox.TabIndex = 24;
            this.displayConvexHullCheckBox.Text = "Otoczka";
            this.displayConvexHullCheckBox.UseVisualStyleBackColor = true;
            // 
            // displayControlPointsCheckBox
            // 
            this.displayControlPointsCheckBox.AutoSize = true;
            this.displayControlPointsCheckBox.Location = new System.Drawing.Point(72, 19);
            this.displayControlPointsCheckBox.Name = "displayControlPointsCheckBox";
            this.displayControlPointsCheckBox.Size = new System.Drawing.Size(106, 17);
            this.displayControlPointsCheckBox.TabIndex = 23;
            this.displayControlPointsCheckBox.Text = "Punkty kontrolne";
            this.displayControlPointsCheckBox.UseVisualStyleBackColor = true;
            // 
            // displayCurveCheckBox
            // 
            this.displayCurveCheckBox.AutoSize = true;
            this.displayCurveCheckBox.Location = new System.Drawing.Point(6, 19);
            this.displayCurveCheckBox.Name = "displayCurveCheckBox";
            this.displayCurveCheckBox.Size = new System.Drawing.Size(60, 17);
            this.displayCurveCheckBox.TabIndex = 22;
            this.displayCurveCheckBox.Text = "Krzywa";
            this.displayCurveCheckBox.UseVisualStyleBackColor = true;
            // 
            // rotateTextBox
            // 
            this.rotateTextBox.Location = new System.Drawing.Point(6, 215);
            this.rotateTextBox.Name = "rotateTextBox";
            this.rotateTextBox.Size = new System.Drawing.Size(46, 20);
            this.rotateTextBox.TabIndex = 18;
            // 
            // moveXTextBox
            // 
            this.moveXTextBox.Location = new System.Drawing.Point(6, 189);
            this.moveXTextBox.Name = "moveXTextBox";
            this.moveXTextBox.Size = new System.Drawing.Size(46, 20);
            this.moveXTextBox.TabIndex = 17;
            // 
            // moveYTextBox
            // 
            this.moveYTextBox.Location = new System.Drawing.Point(58, 189);
            this.moveYTextBox.Name = "moveYTextBox";
            this.moveYTextBox.Size = new System.Drawing.Size(46, 20);
            this.moveYTextBox.TabIndex = 16;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(6, 134);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(141, 20);
            this.nameTextBox.TabIndex = 15;
            // 
            // curvesList
            // 
            this.curvesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.curvesList.FormattingEnabled = true;
            this.curvesList.Location = new System.Drawing.Point(0, 0);
            this.curvesList.Name = "curvesList";
            this.curvesList.Size = new System.Drawing.Size(400, 800);
            this.curvesList.TabIndex = 0;
            this.curvesList.SelectedIndexChanged += new System.EventHandler(this.curvesList_SelectedIndexChanged);
            // 
            // curveSelectorPanel
            // 
            this.curveSelectorPanel.Controls.Add(this.curveTypeSelectionBox);
            this.curveSelectorPanel.Controls.Add(this.curvesList);
            this.curveSelectorPanel.Location = new System.Drawing.Point(1050, 0);
            this.curveSelectorPanel.Name = "curveSelectorPanel";
            this.curveSelectorPanel.Size = new System.Drawing.Size(400, 800);
            this.curveSelectorPanel.TabIndex = 3;
            // 
            // curveTypeSelectionBox
            // 
            this.curveTypeSelectionBox.FormattingEnabled = true;
            this.curveTypeSelectionBox.Location = new System.Drawing.Point(0, 588);
            this.curveTypeSelectionBox.Name = "curveTypeSelectionBox";
            this.curveTypeSelectionBox.Size = new System.Drawing.Size(400, 212);
            this.curveTypeSelectionBox.TabIndex = 1;
            // 
            // errorBox
            // 
            this.errorBox.Location = new System.Drawing.Point(50, 780);
            this.errorBox.Name = "errorBox";
            this.errorBox.ReadOnly = true;
            this.errorBox.Size = new System.Drawing.Size(1000, 20);
            this.errorBox.TabIndex = 16;
            // 
            // showPointButton
            // 
            this.showPointButton.Location = new System.Drawing.Point(138, 241);
            this.showPointButton.Name = "showPointButton";
            this.showPointButton.Size = new System.Drawing.Size(75, 23);
            this.showPointButton.TabIndex = 48;
            this.showPointButton.Text = "Pokaż";
            this.showPointButton.UseVisualStyleBackColor = true;
            this.showPointButton.Click += new System.EventHandler(this.showPointButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1850, 800);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.curvePropertiesGroupBox);
            this.Controls.Add(this.curveManagementPanel);
            this.Controls.Add(this.curveSelectorPanel);
            this.Controls.Add(this.leftBarPanel);
            this.Controls.Add(this.CanvasPanel);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edytor krzywych";
            this.curveManagementPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.redColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditCurveModePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColorPictureBox)).EndInit();
            this.leftBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.curvePropertiesGroupBox.ResumeLayout(false);
            this.curvePropertiesGroupBox.PerformLayout();
            this.curveSelectorPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.Panel curveManagementPanel;
        private System.Windows.Forms.PictureBox redColorPictureBox;
        private System.Windows.Forms.PictureBox blueColorPictureBox;
        private System.Windows.Forms.PictureBox blackColorPictureBox;
        private System.Windows.Forms.PictureBox EditCurveModePictureBox;
        private System.Windows.Forms.PictureBox greenColorPictureBox;
        private System.Windows.Forms.Panel leftBarPanel;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.ListBox curvesList;
        private System.Windows.Forms.Panel curveSelectorPanel;
        private System.Windows.Forms.GroupBox curvePropertiesGroupBox;
        private System.Windows.Forms.TextBox rotateTextBox;
        private System.Windows.Forms.TextBox moveXTextBox;
        private System.Windows.Forms.TextBox moveYTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckBox displayConvexHullCheckBox;
        private System.Windows.Forms.CheckBox displayControlPointsCheckBox;
        private System.Windows.Forms.CheckBox displayCurveCheckBox;
        private System.Windows.Forms.TextBox curveThicknessTextBox;
        private System.Windows.Forms.TextBox controlPointsThicknessTextBox;
        private System.Windows.Forms.ListBox pointsListBox;
        private System.Windows.Forms.Button NewCurveButton;
        private System.Windows.Forms.Button deleteCurve;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.Button copyCurveButton;
        private System.Windows.Forms.Button reversePointsButton;
        private System.Windows.Forms.Button deletePointButton;
        private System.Windows.Forms.Button pointDownButton;
        private System.Windows.Forms.Button pointUpButton;
        private System.Windows.Forms.Button swapPointsButton;
        private System.Windows.Forms.TextBox errorBox;
        private System.Windows.Forms.ListBox curveTypeSelectionBox;
        private System.Windows.Forms.TextBox splitTextBox;
        private System.Windows.Forms.Button splitButton;
        private System.Windows.Forms.Button decreaseButton;
        private System.Windows.Forms.Button elevateButton;
        private System.Windows.Forms.TextBox editWBox;
        private System.Windows.Forms.TextBox editXBox;
        private System.Windows.Forms.TextBox editYBox;
        private System.Windows.Forms.Button editPointButton;
        private System.Windows.Forms.Button combineButton;
        private System.Windows.Forms.TextBox combineSBox;
        private System.Windows.Forms.TextBox combineFBox;
        private System.Windows.Forms.Button showPointButton;
    }
}

