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
        private Action current_action = Action.Move;
        private List<IFigure> figures = new List<IFigure>();
        private Int64 figure_counter = 0;
        private IFigure? drawing_figure = null;

        public Form1()
        {
            InitializeComponent();

            ButtonCancel.Visible = false;
            ButtonRepeat.Visible = false;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            foreach (IFigure figure in figures)
            {
                figure.Draw(e.Graphics);
            }

            if (drawing_figure != null)
            {
                drawing_figure.Draw(e.Graphics);
            }
        }

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
        {
            if (drawing_figure != null)
            {
                drawing_figure.SetPoint(new Point(e.X, e.Y));
                canvas.Refresh();
            }
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (current_action == Action.Move)
            {
                return;
            }

            if (drawing_figure == null)
            {
                switch (current_action)
                {
                    case Action.AddLine:
                        drawing_figure = new Line(
                            figure_counter,
                            new Point(e.X, e.Y),
                            ButtonColorBorder.BackColor);
                        break;
                    case Action.AddRectangle:
                        drawing_figure = new Rectangle(
                            figure_counter,
                            new Point(e.X, e.Y),
                            ButtonColorBorder.BackColor,
                            ButtonColorFill.BackColor);
                        break;
                    case Action.AddEllipse:
                        drawing_figure = new Ellipse(
                            figure_counter,
                            new Point(e.X, e.Y),
                            ButtonColorBorder.BackColor,
                            ButtonColorFill.BackColor);
                        break;
                    case Action.AddPolygon:
                        drawing_figure = new Polygon(
                            figure_counter,
                            (int)VertexCount.Value,
                            new Point(e.X, e.Y),
                            ButtonColorBorder.BackColor,
                            ButtonColorFill.BackColor);
                        break;
                    default: return;
                }

                figure_counter++;
                return;
            }

            drawing_figure.SetPoint(new Point(e.X, e.Y));
            drawing_figure.ConfirmPoint();
            if (drawing_figure.IsFinished())
            {
                figures.Add(drawing_figure);
                drawing_figure = null;
                canvas.Refresh();
            }
        }

        private void ButtonLine_Click(object sender, EventArgs e)
        {
            current_action = Action.AddLine;
        }

        private void ButtonRectangle_Click(object sender, EventArgs e)
        {
            current_action = Action.AddRectangle;
        }

        private void ButtonEllipse_Click(object sender, EventArgs e)
        {
            current_action = Action.AddEllipse;
        }

        private void ButtonPolygon_Click(object sender, EventArgs e)
        {
            current_action = Action.AddPolygon;
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            current_action = Action.Move;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            canvas.Width = this.Width - 40;
            canvas.Height = this.Height - 85;
            canvas.Refresh();
        }
    }
}
