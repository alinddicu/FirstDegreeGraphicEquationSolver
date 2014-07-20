using System.Diagnostics;
using System.Drawing;
using FirstDegreeGraphicEquationSolver.Classes;

namespace FirstDegreeGraphicEquationSolver
{
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public const int PanelBottomMargin = 100;
        public const int PanelLeftMargin = 100;

        private readonly Graphics _graphics;
        private readonly Axis _axis;

        public MainForm()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 600;
            _graphics = drawingPanel.CreateGraphics();
            _axis = new Axis(_graphics, drawingPanel);
        }

        private void MainForm_Shown(object sender, System.EventArgs e)
        {
            _axis.Draw();
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            _graphics.Clear(Color.White);
            _axis.Draw();
            var point = drawingPanel.PointToClient(Cursor.Position);
            var pointRelatifToPanel = new Point(point.X - PanelLeftMargin, point.Y - (drawingPanel.Height - PanelBottomMargin));
            var position = string.Format("({0};{1})", pointRelatifToPanel.X, pointRelatifToPanel.Y);
            var drawingPoint = new Point(point.X, point.Y - 10);
            _graphics.DrawString(position, new Font("Verdana", 10), new SolidBrush(Color.Green), drawingPoint);
        }
    }
}
