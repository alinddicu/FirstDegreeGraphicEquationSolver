

namespace FirstDegreeGraphicEquationSolver.Classes
{
    using System.Drawing;
    using System.Windows.Forms;

    public class Scale
    {
        private const int HalfScaleBattonetWidth = 1;

        private readonly Panel _drawingPanel;
        private GraphPoint _origin;
        private readonly uint _scaleSize;

        public Scale(Panel drawingPanel, GraphPoint origin, uint scaleSize)
        {
            _drawingPanel = drawingPanel;
            _origin = origin;
            _scaleSize = scaleSize;
        }

        public void Draw(Graphics graphics, GraphPoint origin)
        {
            _origin = origin;
            Draw(graphics);
        }

        public void Draw(Graphics graphics)
        {
            for (int i = 1; i < _drawingPanel.Width / _scaleSize + 1; i++)
            {
                var scalePace = (int)_scaleSize * i;
                graphics.DrawLine(Pens.Blue, new Point(_origin.X + scalePace, _origin.Y + HalfScaleBattonetWidth), new Point(_origin.X + scalePace, _origin.Y - HalfScaleBattonetWidth));
                graphics.DrawLine(Pens.Blue, new Point(_origin.X - scalePace, _origin.Y + HalfScaleBattonetWidth), new Point(_origin.X - scalePace, _origin.Y - HalfScaleBattonetWidth));
            }

            for (int i = 1; i < _drawingPanel.Height / _scaleSize + 1; i++)
            {
                var scalePace = (int)_scaleSize * i;
                graphics.DrawLine(Pens.Blue, new Point(_origin.X - HalfScaleBattonetWidth, _origin.Y - scalePace), new Point(_origin.X + HalfScaleBattonetWidth, _origin.Y - scalePace));
                graphics.DrawLine(Pens.Blue, new Point(_origin.X - HalfScaleBattonetWidth, _origin.Y + scalePace), new Point(_origin.X + HalfScaleBattonetWidth, _origin.Y + scalePace));
            }
        }
    }
}
