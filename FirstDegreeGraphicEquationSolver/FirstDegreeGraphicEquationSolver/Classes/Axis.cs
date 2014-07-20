using System.Windows.Forms;

namespace FirstDegreeGraphicEquationSolver.Classes
{
    using System.Drawing;

    public class Axis
    {
        private const int Scale = 10;
        private const int HalfScaleBattonetWidth = 1;

        private readonly Graphics _graphics;
        private readonly Panel _drawingPanel;
        private Line _xAxis;
        private Line _yAxis;

        public Point Origin { get; private set; }

        public Axis(Graphics graphics, Panel drawingPanel)
        {
            _graphics = graphics;
            _drawingPanel = drawingPanel;

            Origin = new Point(0 + MainForm.PanelLeftMargin, _drawingPanel.Height - MainForm.PanelBottomMargin);

            InitAxis();
        }

        public void Draw()
        {
            DrawAxis();
            DrawScale();
        }

        private void InitAxis()
        {
            _xAxis = new Line(new Point(0, Origin.Y), new Point(_drawingPanel.Width, Origin.Y));
            _yAxis = new Line(new Point(Origin.X, 0), new Point(Origin.X, _drawingPanel.Height));
        }

        private void DrawAxis()
        {
            _xAxis.Draw(_graphics, Pens.Red);
            _yAxis.Draw(_graphics, Pens.Red);

            _graphics.DrawEllipse(Pens.Blue, Origin.X-3, Origin.Y-3, 6, 6);
            _graphics.FillPie(new SolidBrush(Color.Blue), Origin.X - 3, Origin.Y - 3, 6, 6, 2, 2);
        }

        private void DrawScale()
        {
            for (int i = 1; i < _drawingPanel.Width / Scale + 1; i++)
            {
                var scalePace = Scale * i;
                _graphics.DrawLine(Pens.Blue, new Point(Origin.X + scalePace, Origin.Y + HalfScaleBattonetWidth), new Point(Origin.X + scalePace, Origin.Y - HalfScaleBattonetWidth));
                _graphics.DrawLine(Pens.Blue, new Point(Origin.X - scalePace, Origin.Y + HalfScaleBattonetWidth), new Point(Origin.X - scalePace, Origin.Y - HalfScaleBattonetWidth));
            }

            for (int i = 1; i < _drawingPanel.Height / Scale + 1; i++)
            {
                var scalePace = Scale * i;
                _graphics.DrawLine(Pens.Blue, new Point(Origin.X - HalfScaleBattonetWidth, Origin.Y - scalePace), new Point(Origin.X + HalfScaleBattonetWidth, Origin.Y - scalePace));
                _graphics.DrawLine(Pens.Blue, new Point(Origin.X - HalfScaleBattonetWidth, Origin.Y + scalePace), new Point(Origin.X + HalfScaleBattonetWidth, Origin.Y + scalePace));
            }
        }
    }
}
