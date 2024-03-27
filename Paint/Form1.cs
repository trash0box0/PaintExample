namespace Paint
{
    public enum Action
    {
        AddLine,
        AddRectangle,
        AddEllipse,
        AddPolygon,
        Move
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {}

        private void ColorSet_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ButtonColorBorder.BackColor = dlg.Color;
                }
            }
        }

        private void ColorFill_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ButtonColorFill.BackColor = dlg.Color;
                }
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {}

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {}

        private void ButtonLine_Click(object sender, EventArgs e)
        {}

        private void ButtonRectangle_Click(object sender, EventArgs e)
        {}

        private void ButtonEllipse_Click(object sender, EventArgs e)
        {}

        private void ButtonPolygon_Click(object sender, EventArgs e)
        {}

        private void ButtonMove_Click(object sender, EventArgs e)
        {}

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            canvas.Width = this.Width - 40;
            canvas.Height = this.Height - 85;
            canvas.Refresh();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {}

        private void ButtonRepeat_Click(object sender, EventArgs e)
        {}
    }
}
