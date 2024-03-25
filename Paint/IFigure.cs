using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public interface IFigure
    {
        Int64 GetID();
        bool CheckCross(Point point);
        void Draw(Graphics graphics);
        void Move(Point location);
        void SetPoint(Point p2, bool is_shift);
        void ConfirmPoint();
        bool IsFinished();
    }

    public abstract class Figure : IFigure
    {
        private Int64 ID;
        protected Point center;
        protected Point first_point;
        protected Color borderColor;
        protected Color fillColor;
        protected bool is_finished;

        public Figure(Int64 ID, Point first_point, Color borderColor, Color fillColor)
        {
            this.ID = ID;
            this.center = first_point;
            this.first_point = first_point;
            this.borderColor = borderColor;
            this.fillColor = fillColor;
            this.is_finished = false;
        }

        public Int64 GetID() { return ID; }

        public abstract bool CheckCross(Point point);
        public abstract void Draw(Graphics graphics);
        public abstract void Move(Point location);

        public abstract void SetPoint(Point point, bool is_shift);
        public abstract void ConfirmPoint();
        public bool IsFinished() { return is_finished; }
    }

    public abstract class TwoPointsBased : Figure
    {
        protected Point      second_point;
        protected RectangleF container_rect;

        public TwoPointsBased(Int64 ID, Point first_point, Color borderColor, Color fillColor) :
            base(ID, first_point, borderColor, fillColor)
        { 
            second_point = first_point;
        }

        public override void Move(Point location)
        {
            int delta_X = center.X - location.X;
            int delta_Y = center.Y - location.Y;

            first_point.X += delta_X;
            first_point.Y += delta_Y;
            second_point.X += delta_X;
            second_point.Y += delta_Y;
            center = location;
        }

        public override void SetPoint(Point p2, bool is_shift)
        {
            second_point = p2;

            center.X = (first_point.X + second_point.X) / 2;
            center.Y = (first_point.Y + second_point.Y) / 2;

            int max_X = second_point.X;
            int min_X = first_point.X;
            int max_Y = second_point.Y;
            int min_Y = first_point.Y;

            if (max_X < min_X)
            {
                int tmp = max_X; max_X = min_X; min_X = tmp;
            }

            if (max_Y < min_Y)
            {
                int tmp = max_Y; max_Y = min_Y; min_Y = tmp;
            }

            container_rect = new RectangleF(min_X, min_Y, max_X - min_X, max_Y - min_Y);
        }

        public override void ConfirmPoint()
        {
            is_finished = true;
        }

        public override bool CheckCross(Point point)
        {
            return container_rect.Contains(point);
        }
    }
}
