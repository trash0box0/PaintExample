namespace Paint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            canvas = new PictureBox();
            ButtonColorBorder = new Button();
            ButtonRectangle = new Button();
            ButtonLine = new Button();
            ButtonPolygon = new Button();
            ButtonEllipse = new Button();
            ButtonColorFill = new Button();
            toolTip = new ToolTip(components);
            ButtonRepeat = new Button();
            ButtonCancel = new Button();
            ButtonMove = new Button();
            VertexCount = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VertexCount).BeginInit();
            SuspendLayout();
            // 
            // canvas
            // 
            canvas.BackColor = SystemColors.Window;
            canvas.Cursor = Cursors.Cross;
            canvas.Location = new Point(12, 128);
            canvas.Name = "canvas";
            canvas.Size = new Size(1410, 580);
            canvas.TabIndex = 0;
            canvas.TabStop = false;
            toolTip.SetToolTip(canvas, "Область рисования");
            canvas.Paint += canvas_Paint;
            canvas.MouseClick += canvas_MouseClick;
            canvas.MouseMove += canvas_MouseMove;
            // 
            // ButtonColorBorder
            // 
            ButtonColorBorder.BackColor = SystemColors.InfoText;
            ButtonColorBorder.Location = new Point(12, 62);
            ButtonColorBorder.Name = "ButtonColorBorder";
            ButtonColorBorder.Size = new Size(50, 50);
            ButtonColorBorder.TabIndex = 1;
            toolTip.SetToolTip(ButtonColorBorder, "Цвет границ");
            ButtonColorBorder.UseVisualStyleBackColor = false;
            ButtonColorBorder.Click += ColorSet_Click;
            // 
            // ButtonRectangle
            // 
            ButtonRectangle.Image = (Image)resources.GetObject("ButtonRectangle.Image");
            ButtonRectangle.Location = new Point(203, 12);
            ButtonRectangle.Name = "ButtonRectangle";
            ButtonRectangle.Size = new Size(50, 50);
            ButtonRectangle.TabIndex = 3;
            toolTip.SetToolTip(ButtonRectangle, "Прямоугольник");
            ButtonRectangle.UseVisualStyleBackColor = true;
            ButtonRectangle.Click += ButtonRectangle_Click;
            // 
            // ButtonLine
            // 
            ButtonLine.Image = (Image)resources.GetObject("ButtonLine.Image");
            ButtonLine.Location = new Point(203, 62);
            ButtonLine.Name = "ButtonLine";
            ButtonLine.Size = new Size(50, 50);
            ButtonLine.TabIndex = 4;
            toolTip.SetToolTip(ButtonLine, "Линия");
            ButtonLine.UseVisualStyleBackColor = true;
            ButtonLine.Click += ButtonLine_Click;
            // 
            // ButtonPolygon
            // 
            ButtonPolygon.Image = (Image)resources.GetObject("ButtonPolygon.Image");
            ButtonPolygon.Location = new Point(252, 62);
            ButtonPolygon.Name = "ButtonPolygon";
            ButtonPolygon.Size = new Size(50, 50);
            ButtonPolygon.TabIndex = 6;
            toolTip.SetToolTip(ButtonPolygon, "Многоугольник");
            ButtonPolygon.UseVisualStyleBackColor = true;
            ButtonPolygon.Click += ButtonPolygon_Click;
            // 
            // ButtonEllipse
            // 
            ButtonEllipse.Image = (Image)resources.GetObject("ButtonEllipse.Image");
            ButtonEllipse.Location = new Point(252, 12);
            ButtonEllipse.Name = "ButtonEllipse";
            ButtonEllipse.Size = new Size(50, 50);
            ButtonEllipse.TabIndex = 5;
            toolTip.SetToolTip(ButtonEllipse, "Эллипс");
            ButtonEllipse.UseVisualStyleBackColor = true;
            ButtonEllipse.Click += ButtonEllipse_Click;
            // 
            // ButtonColorFill
            // 
            ButtonColorFill.Location = new Point(62, 62);
            ButtonColorFill.Name = "ButtonColorFill";
            ButtonColorFill.Size = new Size(50, 50);
            ButtonColorFill.TabIndex = 2;
            toolTip.SetToolTip(ButtonColorFill, "Цвет заливки");
            ButtonColorFill.UseVisualStyleBackColor = true;
            ButtonColorFill.Click += ColorFill_Click;
            // 
            // ButtonRepeat
            // 
            ButtonRepeat.Image = (Image)resources.GetObject("ButtonRepeat.Image");
            ButtonRepeat.Location = new Point(62, 12);
            ButtonRepeat.Name = "ButtonRepeat";
            ButtonRepeat.Size = new Size(50, 50);
            ButtonRepeat.TabIndex = 8;
            toolTip.SetToolTip(ButtonRepeat, "Повторить");
            ButtonRepeat.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            ButtonCancel.BackColor = SystemColors.ControlLightLight;
            ButtonCancel.Image = (Image)resources.GetObject("ButtonCancel.Image");
            ButtonCancel.Location = new Point(12, 12);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(50, 50);
            ButtonCancel.TabIndex = 7;
            toolTip.SetToolTip(ButtonCancel, "Отменить");
            ButtonCancel.UseVisualStyleBackColor = false;
            // 
            // ButtonMove
            // 
            ButtonMove.Image = (Image)resources.GetObject("ButtonMove.Image");
            ButtonMove.Location = new Point(302, 12);
            ButtonMove.Name = "ButtonMove";
            ButtonMove.Size = new Size(50, 50);
            ButtonMove.TabIndex = 9;
            toolTip.SetToolTip(ButtonMove, "Двигать");
            ButtonMove.UseVisualStyleBackColor = true;
            ButtonMove.Click += ButtonMove_Click;
            // 
            // VertexCount
            // 
            VertexCount.Location = new Point(302, 72);
            VertexCount.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            VertexCount.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            VertexCount.Name = "VertexCount";
            VertexCount.Size = new Size(50, 27);
            VertexCount.TabIndex = 11;
            toolTip.SetToolTip(VertexCount, "Количество вершин многоугольника");
            VertexCount.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1432, 718);
            Controls.Add(VertexCount);
            Controls.Add(ButtonMove);
            Controls.Add(ButtonRepeat);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonColorFill);
            Controls.Add(ButtonPolygon);
            Controls.Add(ButtonEllipse);
            Controls.Add(ButtonLine);
            Controls.Add(ButtonRectangle);
            Controls.Add(ButtonColorBorder);
            Controls.Add(canvas);
            Name = "Form1";
            Text = "Form1";
            ResizeEnd += Form1_ResizeEnd;
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            ((System.ComponentModel.ISupportInitialize)VertexCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox canvas;
        private Button ButtonColorBorder;
        private Button ButtonRectangle;
        private Button ButtonLine;
        private Button ButtonPolygon;
        private Button ButtonEllipse;
        private Button ButtonColorFill;
        private ToolTip toolTip;
        private Button ButtonRepeat;
        private Button ButtonCancel;
        private Button ButtonMove;
        private NumericUpDown VertexCount;
    }
}
