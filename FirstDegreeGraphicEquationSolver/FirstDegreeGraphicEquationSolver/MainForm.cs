namespace FirstDegreeGraphicEquationSolver
{
    using Classes;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private const int InitWidth = 800;
        private const int InitHeight = 600;
        private const int ScaleSize = 10;

        private Origin _origin;
        private readonly Axis _axis;
        private readonly Scale _scale;

        public MainForm()
        {
            InitializeComponent();
            Width = InitWidth;
            Height = InitHeight;
            _drawingPanel.BackColor = Color.White;
            GenerateOrigin();
            _axis = new Axis(_drawingPanel, _origin);
            _scale = new Scale(_drawingPanel, _origin, ScaleSize);
        }

        private int PanelLeftMargin
        {
            get
            {
                return _drawingPanel.Width / 2;
            }
        }

        private int PanelBottomMargin
        {
            get
            {
                return _drawingPanel.Height / 2;
            }
        }

        #region Form events

        private void MainForm_Shown(object sender, EventArgs e)
        {
            _axis.Draw(GenerateDrawingGraphics());
            _scale.Draw(GenerateDrawingGraphics());
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (_axis == null || _scale == null) return;

            _drawingPanel.Refresh();
            GenerateOrigin();
            _axis.Draw(GenerateDrawingGraphics(), _origin);
            _scale.Draw(GenerateDrawingGraphics(), _origin);
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            var point = _drawingPanel.PointToClient(Cursor.Position);
            PrintMousePointerPosition(ConvertMousePointerPositionToSystemPosition(point));
        }

        #endregion

        private void GenerateOrigin()
        {
            _origin = new Origin(PanelLeftMargin, PanelBottomMargin);
        }

        private Graphics GenerateDrawingGraphics()
        {
            return _drawingPanel.CreateGraphics();
        }

        private Point ConvertMousePointerPositionToSystemPosition(Point point)
        {
            return new Point(point.X - PanelLeftMargin, -point.Y + (_drawingPanel.Height - PanelBottomMargin));
        }

        private RealPoint ApplyScale(Point p)
        {
            return new RealPoint((double)p.X / ScaleSize, (double)p.Y / ScaleSize);
        }

        private void PrintMousePointerPosition(Point mousePointerPosition)
        {
            var realPoint = ApplyScale(mousePointerPosition);
            mousePointerPositionLabel.Text = string.Format("(X;Y) = ({0};{1})", realPoint.X, realPoint.Y);
        }
    }
}
