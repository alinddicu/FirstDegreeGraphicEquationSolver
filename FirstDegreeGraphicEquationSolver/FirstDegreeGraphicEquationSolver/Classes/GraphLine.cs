namespace FirstDegreeGraphicEquationSolver.Classes
{
    using System.Drawing;

    public class GraphLine
    {
        private readonly GraphPoint _point1;
        private readonly GraphPoint _point2;

        public GraphLine(Point point1, Point point2)
        {
            _point1 = new GraphPoint(point1);
            _point2 = new GraphPoint(point2);
        }

        public void Draw(Graphics graphics, PointConverter pointConverter, Pen pen)
        {
            graphics.DrawLine(pen, pointConverter.Convert(_point1.Point), pointConverter.Convert(_point2.Point));
        }

        public bool HasPoint(Point checkPoint)
        {
            // {{qx - px, qy - py}, {rx - px, ry - py}}
            // (qx - px) * (ry - py) - (qy - py) * (rx - px)
            return (_point1.X - _point2.X) * (checkPoint.Y - _point2.Y) - (_point1.Y - _point2.Y) * (checkPoint.X - _point1.X) == 0;
        }
    }
}
