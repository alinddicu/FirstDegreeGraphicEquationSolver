namespace FirstDegreeGraphicEquationSolver.Classes
{
    using System.Drawing;

    public class AxisLine
    {
        private readonly Point _point1;
        private readonly Point _point2;

        public AxisLine(Point point1, Point point2)
        {
            _point1 = point1;
            _point2 = point2;
        }

        public void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, _point1, _point2);
        }

        public bool HasPoint(Point checkPoint)
        {
            // {{qx - px, qy - py}, {rx - px, ry - py}}
            // (qx - px) * (ry - py) - (qy - py) * (rx - px)
            return (_point1.X - _point2.X) * (checkPoint.Y - _point2.Y) - (_point1.Y - _point2.Y) * (checkPoint.X - _point1.X) == 0;
        }
    }
}
