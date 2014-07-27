using System.Globalization;

namespace FirstDegreeGraphicEquationSolver.Classes
{
    using System.Drawing;

    public class GraphPoint
    {
        private Point _point;

        public GraphPoint(int x, int y)
        {
            _point = new Point(x, y);
        }

        public GraphPoint(Point p)
        {
            _point = p;
        }

        public int X
        {
            get { return _point.X; }
        }

        public int Y
        {
            get { return _point.Y; }
        }

        public Point Point
        {
            get { return _point; }
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "({0};{1})", X, Y);
        }
    }
}
