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
    }
}
