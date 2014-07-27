namespace FirstDegreeGraphicEquationSolver.Classes
{
    using System.Drawing;

    public class PointConverter
    {
        private readonly GraphPoint _origin;

        public PointConverter(GraphPoint origin)
        {
            _origin = origin;
        }

        public int GetPanelWidth()
        {
            return _origin.X * 2;
        }

        public Point ConvertToPanelCoords(Point point)
        {
            return new Point(point.X + _origin.X, -point.Y + _origin.Y);
        }

        public Point ConvertToAbsoluteCoords(Point point)
        {
            return new Point(point.X - _origin.X, -point.Y + _origin.Y);
        }
    }
}
