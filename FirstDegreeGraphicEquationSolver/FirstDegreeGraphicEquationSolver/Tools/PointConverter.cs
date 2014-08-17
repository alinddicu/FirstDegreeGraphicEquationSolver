namespace FirstDegreeGraphicEquationSolver.Tools
{
    using Objects;
    using System.Drawing;

    public class PointConverter
    {
        private readonly Point _origin;

        public PointConverter(Point origin)
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

        public Point ConvertToScreenCoords(Point point)
        {
            return new Point(point.X - _origin.X, -point.Y + _origin.Y);
        }
    }
}
