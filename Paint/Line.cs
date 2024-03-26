using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    internal class Line : TwoPointsBased
    {
        public Line(Int64 ID, Point location, Color borderColor) :
            base(ID, location, borderColor, borderColor)
        {}

        public override bool CheckCross(Point point)
        {
            if (!base.CheckCross(point)) return false;

            double distance = Math.Abs(
                (second_point.Y - first_point.Y) * point.X - 
                (second_point.X - first_point.X) * point.Y +
                second_point.X * first_point.Y -
                second_point.Y * first_point.X) /
                Math.Sqrt((second_point.Y - first_point.Y) * (second_point.Y - first_point.Y) +
                (second_point.X - first_point.X) * (second_point.X - first_point.X));

            return distance < 10;
        }

        public override void Draw(Graphics graphics)
        {
            if (first_point == second_point) return;

            Pen pen = new Pen(borderColor, 5);
            graphics.DrawLine(pen, first_point, second_point);

            base.Draw(graphics);
        }
    }
}
