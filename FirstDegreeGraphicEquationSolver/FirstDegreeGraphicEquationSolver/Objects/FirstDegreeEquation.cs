namespace FirstDegreeGraphicEquationSolver.Objects
{
    using System.Globalization;

    public class FirstDegreeEquation
    {
        public FirstDegreeEquation(double a, double b)
        {
            A = a;
            B = b;
        }

        public double A { get; private set; }

        public double B { get; private set; }

        public double GetY(double x)
        {
            return A * x + B;
        }

        public override string ToString()
        {
            var formatA = string.Empty;
            var formatB = string.Empty;

            if (A != 0)
            {
                formatA = "{0}*x";
                if (A == 1.0)
                {
                    formatA = "x";
                }
            }

            if (B != 0)
            {
                formatB = "{1}";
                if (A == 1.0)
                {
                    formatB = "+{1}";
                }
            }

            var formatString = "f(x) = " + formatA + formatB;
            return string.Format(CultureInfo.CurrentCulture, formatString, A, B);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return Equals(obj as FirstDegreeEquation);
        }

        public bool Equals(FirstDegreeEquation otherEquation)
        {
            return otherEquation != null && A == otherEquation.A && B == otherEquation.B;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
