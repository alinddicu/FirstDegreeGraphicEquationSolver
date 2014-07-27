namespace FirstDegreeGraphicEquationSolver.Classes
{
    using System.Drawing;

    public class GraphLine
    {
        private readonly GraphPoint _graphPoint1;
        private readonly GraphPoint _graphPoint2;

        public GraphLine(Point point1, Point point2)
        {
            _graphPoint1 = new GraphPoint(point1);
            _graphPoint2 = new GraphPoint(point2);
        }

        public void Draw(Graphics graphics, Pen pen, PointConverter pointConverter)
        {
            var drawingPoint1 = new Point(pointConverter.GetPanelWidth(), GetY(pointConverter.GetPanelWidth()));
            var drawingPoint2 = new Point(-pointConverter.GetPanelWidth(), GetY(-pointConverter.GetPanelWidth()));
            drawingPoint1 = pointConverter.ConvertByAddingOrigin(drawingPoint1);
            drawingPoint2 = pointConverter.ConvertByAddingOrigin(drawingPoint2);
            graphics.DrawLine(pen, drawingPoint1, drawingPoint2);
        }

        public int GetY(int x)
        {
            var a = (_graphPoint2.Y - _graphPoint1.Y) / (_graphPoint2.X - _graphPoint1.X);
            var b = _graphPoint1.Y - a * _graphPoint1.X;

            return a * x + b;
        }

        public bool HasPoint(Point checkPoint)
        {
            // {{qx - px, qy - py}, {rx - px, ry - py}}
            // (qx - px) * (ry - py) - (qy - py) * (rx - px)
            return (_graphPoint1.X - _graphPoint2.X) * (checkPoint.Y - _graphPoint2.Y) - (_graphPoint1.Y - _graphPoint2.Y) * (checkPoint.X - _graphPoint1.X) == 0;
        }
    }
}
