namespace FirstDegreeGraphicEquationSolver.Drawers
{
    using Objects;
    using System.Drawing;
    using System.Windows.Forms;

    public class ScaleDrawer
    {
        private readonly int _halfScaleBattonetWidth = 1;
        private readonly Panel _drawingPanel;
        private GraphPoint _origin;
        private readonly Scale _scale;

        public ScaleDrawer(Panel drawingPanel, GraphPoint origin, Scale scale)
        {
            _drawingPanel = drawingPanel;
            _origin = origin;
            _scale = scale;
            _halfScaleBattonetWidth = scale.HalfScaleBattonetWidth;
        }

        private int HalfScaleBattonetWidth
        {
            get { return _halfScaleBattonetWidth; }
        }

        public void Draw(Graphics graphics, GraphPoint origin)
        {
            _origin = origin;
            Draw(graphics);
        }

        public void Draw(Graphics graphics)
        {
            DrawOnX(graphics);
            DrawOnY(graphics);
        }

        private void DrawOnY(Graphics graphics)
        {
            var pixelsScaleUnit = _scale.Pixels;

            for (var i = 1; i < _drawingPanel.Height / pixelsScaleUnit + 1; i++)
            {
                var scalePace = pixelsScaleUnit * i;
                graphics.DrawLine(Pens.Blue, new Point(_origin.X - HalfScaleBattonetWidth, _origin.Y - scalePace),
                    new Point(_origin.X + HalfScaleBattonetWidth, _origin.Y - scalePace));
                graphics.DrawLine(Pens.Blue, new Point(_origin.X - HalfScaleBattonetWidth, _origin.Y + scalePace),
                    new Point(_origin.X + HalfScaleBattonetWidth, _origin.Y + scalePace));
            }
        }

        private void DrawOnX(Graphics graphics)
        {
            var pixelsScaleUnit = _scale.Pixels;

            for (var i = 1; i < _drawingPanel.Width / pixelsScaleUnit + 1; i++)
            {
                var scalePace = pixelsScaleUnit * i;
                graphics.DrawLine(Pens.Blue, new Point(_origin.X + scalePace, _origin.Y + HalfScaleBattonetWidth),
                    new Point(_origin.X + scalePace, _origin.Y - HalfScaleBattonetWidth));
                graphics.DrawLine(Pens.Blue, new Point(_origin.X - scalePace, _origin.Y + HalfScaleBattonetWidth),
                    new Point(_origin.X - scalePace, _origin.Y - HalfScaleBattonetWidth));
            }
        }
    }
}
