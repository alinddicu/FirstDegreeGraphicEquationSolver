namespace FirstDegreeGraphicEquationSolver.Classes
{
    using System.Drawing;
    public class PointConverter
    {
        private readonly int _panelWidth;
        private readonly int _panelHeight;

        public PointConverter(int panelWidth, int panelHeight)
        {
            _panelWidth = panelWidth;
            _panelHeight = panelHeight;
        }

        public Point Convert(Point point)
        {
            return new Point(point.X + _panelWidth / 2, -point.Y + (_panelHeight / 2));
        }

        public Point Convert2(Point point)
        {
            return new Point(point.X - _panelWidth / 2, -point.Y + _panelHeight / 2);
        }
    }
}
