namespace FirstDegreeGraphicEquationSolver.Objects
{
    using System.Drawing;

    public class Scale
    {
        public int HalfScaleBattonetWidth { get; private set; }
        public int Pixels { get; private set; }
        private int Unit { get; set; }

        public Scale(int pixels, int halfScaleBattonetWidth, int unit = 1)
        {
            HalfScaleBattonetWidth = halfScaleBattonetWidth;
            Unit = unit;
            Pixels = pixels;
        }

        public double Get()
        {
            return Pixels / Unit;
        }

        public RealPoint Apply(Point p)
        {
            return new RealPoint((double)p.X / Pixels, (double)p.Y / Pixels);
        }
    }
}
