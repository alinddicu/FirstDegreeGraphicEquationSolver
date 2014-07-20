namespace FirstDegreeGraphicEquationSolver.Classes
{
    using System.Drawing;

    public class Origin
    {
        private Point _point;

        public Origin(int x, int y)
        {
            _point = new Point(x, y);
        }

        public int X
        {
            get { return _point.X; }
        }

        public int Y
        {
            get { return _point.Y; }
        }

    }
}
