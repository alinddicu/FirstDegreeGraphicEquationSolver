namespace FirstDegreeGraphicEquationSolver.Objects
{
    public class FirstDegreeEquation
    {
        private double _a;
        private double _b;

        public FirstDegreeEquation(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public double GetY(double x)
        {
            return _a * x + _b;
        }
    }
}
