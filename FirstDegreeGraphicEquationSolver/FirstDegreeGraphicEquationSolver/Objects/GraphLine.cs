namespace FirstDegreeGraphicEquationSolver.Objects
{
    using System.Drawing;

    public class GraphLine
    {
        private readonly Point _point1;
        private readonly Point _point2;
        private readonly FirstDegreeEquation _equation;

        public GraphLine(FirstDegreeEquation equation)
        {
            _equation = equation;
            _point1 = new Point(0, (int)_equation.GetY(0));
            _point2 = new Point(1, (int)_equation.GetY(1));
        }

        public int GetY(int x, int scaleFactor)
        {
            var a = (_point2.Y - _point1.Y) / (_point2.X - _point1.X);
            var b = _point1.Y - a * _point1.X;

            return a * x + b * scaleFactor;
        }

        public bool HasScreenCoordsPoint(Point checkPoint, int scaleFactor)
        {
            // {{qx - px, qy - py}, {rx - px, ry - py}}

            // (qx - px) * (ry - py) - (qy - py) * (rx - px)

            // q = point1
            // r = point2
            // p = checkPoint
            var left = (_point1.X - checkPoint.X) * (GetY(_point2.X, scaleFactor) - checkPoint.Y);
            var right = (GetY(_point1.X, scaleFactor) - checkPoint.Y) * (_point2.X - checkPoint.X);

            return left == right;
        }
    }
}
