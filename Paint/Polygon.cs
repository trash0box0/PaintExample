using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    internal class Polygon : Figure
    {
        private int point_index;
        private Point[] points;

        public Polygon(Int64 ID, int VertexCount, Point first_point, Color borderColor, Color fillColor) :
            base(ID, first_point, borderColor, fillColor)
        {
            if (VertexCount < 3)
                throw new Exception("Invalid polygon");
            point_index = 1;
            points = new Point[VertexCount];

            Array.Fill(points, first_point);
        }

        public override void Move(Point location)
        {
            if (is_finished) return;
        }

        public override void SetPoint(Point p2)
        {
            if (is_finished) return;

            points[point_index] = p2;

            // recalc center
            center.X = 0;
            center.Y = 0;
            for (int i = 0; i < points.Length;i++)
            {
                center.X += points[i].X;
                center.Y += points[i].Y;
            }

            center.X /= points.Length;
            center.Y /= points.Length;

            // recalc containing rect
            int max_X = points.Max(p => p.X);
            int min_X = points.Min(p => p.X);
            int max_Y = points.Max(p => p.Y);
            int min_Y = points.Min(p => p.Y);

            container_rect = new RectangleF(min_X, min_Y, max_X - min_X, max_Y - min_Y);
        }

        public override void ConfirmPoint()
        {
            if (is_finished) return;

            point_index++;
            if (point_index >= points.Length)
                is_finished = true;
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(borderColor, 5);
            Brush brush = new SolidBrush(fillColor);

            graphics.FillPolygon(brush, points);
            graphics.DrawPolygon(pen, points);

            base.Draw(graphics);
        }
    }
}
