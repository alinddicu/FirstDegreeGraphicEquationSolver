namespace FirstDegreeGraphicEquationSolver.Objects
{
    using System.Drawing;

    public class Scale
    {
        public int HalfScaleBattonetWidth { get; private set; }
        public int Pixels { get; private set; }
        private int Unit { get; set; }

        public Scale(int pixels, int halfScaleBattonetWidth, int unit)
        {
            HalfScaleBattonetWidth = halfScaleBattonetWidth;
            Unit = unit;
            Pixels = pixels;
        }

        public int GetScaleFactor()
        {
            return Pixels / Unit;
        }

        public RealPoint Apply(Point p)
        {
            return new RealPoint((double)p.X / GetScaleFactor(), (double)p.Y / GetScaleFactor());
        }
    }
}
