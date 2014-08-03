namespace FirstDegreeGraphicEquationSolver.Drawers
{
    using Objects;
    using System.Drawing;
    using PointConverter = Tools.PointConverter;

    public class GraphLineDrawer
    {
        private readonly PointConverter _pointConverter;

        public GraphLineDrawer(PointConverter pointConverter)
        {
            _pointConverter = pointConverter;
        }

        public void Draw(Graphics graphics, GraphLine line, Pen pen, int scaleFactor)
        {
            var drawingPoint1 = new Point(_pointConverter.GetPanelWidth(), line.GetY(_pointConverter.GetPanelWidth(), scaleFactor));
            var drawingPoint2 = new Point(-_pointConverter.GetPanelWidth(), line.GetY(-_pointConverter.GetPanelWidth(), scaleFactor));
            drawingPoint1 = _pointConverter.ConvertToPanelCoords(drawingPoint1);
            drawingPoint2 = _pointConverter.ConvertToPanelCoords(drawingPoint2);
            graphics.DrawLine(pen, drawingPoint1, drawingPoint2);
        }
    }
}
