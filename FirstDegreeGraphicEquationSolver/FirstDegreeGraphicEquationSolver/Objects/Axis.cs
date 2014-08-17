namespace FirstDegreeGraphicEquationSolver.Objects
{
    using System.Drawing;
    using System.Windows.Forms;

    public class Axis
    {
        public Point Origin { get; set; }
        public AxisLine X { get; private set; }
        public AxisLine Y { get; private set; }

        public Axis(Panel drawingPanel, Point origin)
        {
            Origin = origin;
            InitAxis(drawingPanel);
        }

        public void InitAxis(Panel drawingPanel)
        {
            X = new AxisLine(new Point(0, Origin.Y), new Point(drawingPanel.Width, Origin.Y));
            Y = new AxisLine(new Point(Origin.X, 0), new Point(Origin.X, drawingPanel.Height));
        }
    }
}
