using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    internal class Ellipse : TwoPointsBased
    {
        public Ellipse(Int64 ID, Point location, Color borderColor, Color fillColor) :
            base(ID, location, borderColor, fillColor)
        { }

        public override void Draw(Graphics graphics)
        {
            if (first_point == second_point) return;

            Pen pen = new Pen(borderColor, 5);
            Brush brush = new SolidBrush(fillColor);
            graphics.FillEllipse(brush, container_rect);
            graphics.DrawEllipse(pen,
                container_rect.X,
                container_rect.Y,
                container_rect.Width,
                container_rect.Height);

            base.Draw(graphics);
        }
    }
}
