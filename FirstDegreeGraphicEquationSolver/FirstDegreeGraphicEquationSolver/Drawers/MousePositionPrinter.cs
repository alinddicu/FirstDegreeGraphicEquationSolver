namespace FirstDegreeGraphicEquationSolver.Drawers
{
    using FirstDegreeGraphicEquationSolver.Objects;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;
    using PanelPointConverter = Tools.PointConverter;

    public class MousePositionPrinter
    {
        private readonly Panel _panel;
        private readonly Scale _scale;
        private readonly PanelPointConverter _pointConverter;

        public MousePositionPrinter(Panel panel, Scale scale, PanelPointConverter pointConverter)
        {
            _panel = panel;
            _scale = scale;
            _pointConverter = pointConverter;
        }

        public string Print(Point mousePointerPosition)
        {
            var point = _panel.PointToClient(mousePointerPosition);
            var realPoint = _scale.Apply(_pointConverter.ConvertToScreenCoords(point));
            return string.Format(CultureInfo.CurrentCulture, "(X;Y) = ({0};{1})", realPoint.X, realPoint.Y);
        }
    }
}
