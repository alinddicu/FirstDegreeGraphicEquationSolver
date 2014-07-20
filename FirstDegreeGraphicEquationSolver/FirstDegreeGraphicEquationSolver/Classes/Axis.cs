using System.Windows.Forms;

namespace FirstDegreeGraphicEquationSolver.Classes
{
    using System.Drawing;

    public class Axis
    {
        private readonly Panel _drawingPanel;
        private Origin _origin;
        private Line _xAxis;
        private Line _yAxis;

        public Axis(Panel drawingPanel, Origin origin)
        {
            _drawingPanel = drawingPanel;
            _origin = origin;
            InitAxis();
        }

        public void Draw(Graphics graphics)
        {
            InitAxis();
            DrawAxis(graphics);
        }

        public void Draw(Graphics graphics, Origin origin)
        {
            _origin = origin;
            Draw(graphics);
        }

        private void InitAxis()
        {
            _xAxis = new Line(new Point(0, _origin.Y), new Point(_drawingPanel.Width, _origin.Y));
            _yAxis = new Line(new Point(_origin.X, 0), new Point(_origin.X, _drawingPanel.Height));
        }

        private void DrawAxis(Graphics graphics)
        {
            _xAxis.Draw(graphics, Pens.Red);
            _yAxis.Draw(graphics, Pens.Red);

            graphics.DrawEllipse(Pens.Blue, _origin.X-3, _origin.Y-3, 6, 6);
            graphics.FillPie(new SolidBrush(Color.Blue), _origin.X - 3, _origin.Y - 3, 6, 6, 2, 2);
        }
    }
}
