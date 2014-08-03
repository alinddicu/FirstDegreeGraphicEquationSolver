namespace FirstDegreeGraphicEquationSolver.Objects
{
    using System.Drawing;

    public class AxisLine
    {
        public Point Point1 { get; private set; }
        public Point Point2 { get; private set; }

        public AxisLine(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }
    }
}
