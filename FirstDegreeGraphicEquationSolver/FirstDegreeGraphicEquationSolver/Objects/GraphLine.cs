namespace FirstDegreeGraphicEquationSolver.Objects
{
    using System.Drawing;
    using PointConverter = Tools.PointConverter;

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
            drawingPoint1 = pointConverter.ConvertToPanelCoords(drawingPoint1);
            drawingPoint2 = pointConverter.ConvertToPanelCoords(drawingPoint2);
            graphics.DrawLine(pen, drawingPoint1, drawingPoint2);
        }

        public int GetY(int x)
        {
            var a = (_graphPoint2.Y - _graphPoint1.Y) / (_graphPoint2.X - _graphPoint1.X);
            var b = _graphPoint1.Y - a * _graphPoint1.X;

            return a * x + b;
        }

        public bool HasScreenCoordsPoint(Point checkPoint)
        {
            // {{qx - px, qy - py}, {rx - px, ry - py}}

            // (qx - px) * (ry - py) - (qy - py) * (rx - px)

            // q = point1
            // r = point2
            // p = checkPoint
            var left = (_graphPoint1.X - checkPoint.X) * (_graphPoint2.Y - checkPoint.Y);
            var right = (_graphPoint1.Y - checkPoint.Y) * (_graphPoint2.X - checkPoint.X);

            return left == right;
        }
    }
}
