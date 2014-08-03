namespace FirstDegreeGraphicEquationSolver.Objects
{
    public class RealPoint
    {
        public RealPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; private set; }

        public double Y { get; private set; }
    }
}
