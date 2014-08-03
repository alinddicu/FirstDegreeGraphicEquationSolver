namespace FirstDegreeGraphicEquationSolver.Drawers
{
    using Objects;
    using System.Drawing;
    using System.Windows.Forms;

    public class AxisDrawer
    {
        private readonly Panel _drawingPanel;
        private readonly Axis _axis;

        public AxisDrawer(Panel drawingPanel, Axis axis)
        {
            _drawingPanel = drawingPanel;
            _axis = axis;
        }

        public void Draw(Graphics graphics)
        {
            _axis.InitAxis(_drawingPanel);
            DrawAxis(graphics);
        }

        public void Draw(Graphics graphics, GraphPoint origin)
        {
            _axis.Origin = origin;
            Draw(graphics);
        }

        private void DrawAxis(Graphics graphics)
        {
            graphics.DrawLine(Pens.Red, _axis.X.Point1, _axis.X.Point2);
            graphics.DrawLine(Pens.Red, _axis.Y.Point1, _axis.Y.Point2);

            graphics.DrawEllipse(Pens.Blue, _axis.Origin.X - 3, _axis.Origin.Y - 3, 6, 6);
            graphics.FillPie(new SolidBrush(Color.Blue), _axis.Origin.X - 3, _axis.Origin.Y - 3, 6, 6, 2, 2);
        }
    }
}
