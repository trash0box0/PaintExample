using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    internal interface IFigure
    {
        Int64 GetID();
        bool CheckCross(Point point);
        void Draw(Graphics graphics);
        void Move(Point location);
        void SetPoint(Point p2);
        void ConfirmPoint();
        bool IsFinished();
    }

    internal abstract class Figure : IFigure
    {
        private Int64 ID;
        protected Point center;
        protected Point first_point;
        protected Color borderColor;
        protected Color fillColor;
        protected bool is_finished;
        protected RectangleF container_rect;

        public Figure(Int64 ID, Point first_point, Color borderColor, Color fillColor)
        {
            this.ID = ID;
            this.center = first_point;
            this.first_point = first_point;
            this.borderColor = borderColor;
            this.fillColor = fillColor;
            this.is_finished = false;
            this.container_rect = 
                new RectangleF(first_point.X, first_point.Y, 0, 0);
        }

        public Int64 GetID() { return ID; }

        public abstract void Move(Point location);

        public abstract void SetPoint(Point point);
        public abstract void ConfirmPoint();
        public bool IsFinished() { return is_finished; }

        public virtual void Draw(Graphics graphics)
        {
#if DEBUG
            // draw debug info
            // draw center
            Pen pen = new Pen(Color.Green, 2);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Brush brush = new SolidBrush(Color.Blue);
            graphics.FillEllipse(brush, center.X - 3, center.Y - 3, 6, 6);

            // draw container rect
            graphics.DrawRectangle(pen,
                container_rect.X,
                container_rect.Y,
                container_rect.Width,
                container_rect.Height);
#endif
        }

        public virtual bool CheckCross(Point point)
        {
            return container_rect.Contains(point);
        }
    }

    internal abstract class TwoPointsBased : Figure
    {
        protected Point      second_point;

        public TwoPointsBased(Int64 ID, Point first_point, Color borderColor, Color fillColor) :
            base(ID, first_point, borderColor, fillColor)
        { 
            second_point = first_point;
        }

        public override void Move(Point location)
        {
            if (!is_finished) return;

            int delta_X = center.X - location.X;
            int delta_Y = center.Y - location.Y;

            first_point.X += delta_X;
            first_point.Y += delta_Y;
            second_point.X += delta_X;
            second_point.Y += delta_Y;
            center = location;

            container_rect.X += delta_X;
            container_rect.Y += delta_Y;
        }

        public override void SetPoint(Point p2)
        {
            if (is_finished) return;

            second_point = p2;

            center.X = (first_point.X + second_point.X) / 2;
            center.Y = (first_point.Y + second_point.Y) / 2;

            int max_X = Math.Max(first_point.X, second_point.X);
            int min_X = Math.Min(first_point.X, second_point.X);
            int max_Y = Math.Max(first_point.Y, second_point.Y);
            int min_Y = Math.Min(first_point.Y, second_point.Y);

            container_rect = new RectangleF(min_X, min_Y, max_X - min_X, max_Y - min_Y);
        }

        public override void ConfirmPoint()
        {
            is_finished = true;
        }
    }
}
