using System.Drawing;
using System.Windows.Forms;

namespace FirstDegreeGraphicEquationSolver.Drawers
{
    using FirstDegreeGraphicEquationSolver.Objects;

    public class AxisDrawer
    {
        private readonly Axis _axis;

        public AxisDrawer(Panel drawingPanel, Axis axis)
        {
            _axis = axis;
        }

        //public void Draw(Graphics graphics)
        //{
        //    InitAxis();
        //    DrawAxis(graphics);
        //}

        //public void Draw(Graphics graphics, GraphPoint origin)
        //{
        //    _origin = origin;
        //    Draw(graphics);
        //}

        //private void DrawAxis(Graphics graphics)
        //{
        //    _xAxis.Draw(graphics, Pens.Red);
        //    _yAxis.Draw(graphics, Pens.Red);

        //    graphics.DrawEllipse(Pens.Blue, _origin.X - 3, _origin.Y - 3, 6, 6);
        //    graphics.FillPie(new SolidBrush(Color.Blue), _origin.X - 3, _origin.Y - 3, 6, 6, 2, 2);
        //}
    }
}
