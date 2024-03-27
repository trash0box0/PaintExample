using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    internal interface IPaintAction
    {
        void OnCancel(List<IFigure> figures);
        void OnRepeat(List<IFigure> figures);
    }

    internal abstract class PaintAction : IPaintAction
    {
        protected IFigure figure;

        public PaintAction(IFigure figure)
        {
            this.figure = figure;
        }

        public abstract void OnCancel(List<IFigure> figures);
        public abstract void OnRepeat(List<IFigure> figures);
    }

    internal class MoveAction : PaintAction
    {
        protected Point before;
        protected Point after;

        public MoveAction(IFigure figure, Point before, Point after) :
            base(figure)
        {
            this.before = before;
            this.after = after;
        }

        public override void OnCancel(List<IFigure> figures)
        {
            figure.Move(before);
        }
        public override void OnRepeat(List<IFigure> figures)
        {
            figure.Move(after);
        }
    }

    internal class AddAction : PaintAction
    {
        public AddAction(IFigure figure) :
            base(figure)
        { }

        public override void OnCancel(List<IFigure> figures)
        {
            figures.Remove(figure);
        }
        public override void OnRepeat(List<IFigure> figures)
        {
            figures.Add(figure);
        }
    }
}
