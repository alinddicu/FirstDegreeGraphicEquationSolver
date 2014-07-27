namespace FirstDegreeGraphicEquationSolver
{
    using Classes;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using PointConverter = Classes.PointConverter;

    public partial class MainForm : Form
    {
        private const int InitWidth = 800;
        private const int InitHeight = 600;
        private const int InitScaleSize = 10;

        private GraphPoint _origin;
        private Axis _axis;
        private Scale _scale;
        private PointConverter _pointConverter;
        private readonly List<GraphLine> _lines = new List<GraphLine>();

        public MainForm()
        {
            InitForm();
            InitGraph();
        }

        private int PanelWidth
        {
            get
            {
                return _drawingPanel.Width;
            }
        }

        private int PanelHeight
        {
            get
            {
                return _drawingPanel.Height;
            }
        }

        private int PanelLeftMargin
        {
            get
            {
                return _drawingPanel.Width / 2;
            }
        }

        private int PanelTopMargin
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
            AddTestsLines();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (_axis == null || _scale == null) return;

            _drawingPanel.Refresh();
            GenerateOrigin();
            GeneratePointConverter();
            _axis.Draw(GenerateDrawingGraphics(), _origin);
            _scale.Draw(GenerateDrawingGraphics(), _origin);
            AddTestsLines();
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            var point = _drawingPanel.PointToClient(Cursor.Position);
            PrintMousePointerPosition(_pointConverter.ConvertBySubstractingOrigin(point));
        }

        #endregion

        private void AddTestsLines()
        {
            _lines.Clear();
            _lines.Add(new GraphLine(new Point(0, 0), new Point(10, 10)));
            _lines.Add(new GraphLine(new Point(0, 0), new Point(10, 20)));
            _lines.Add(new GraphLine(new Point(0, 10), new Point(10, 20)));
            
            DrawTestLines();
        }

        private void DrawTestLines()
        {
            GeneratePointConverter();
            foreach (var line in _lines)
            {
                line.Draw(GenerateDrawingGraphics(), Pens.Black, _pointConverter);
            }
        }

        private void InitForm()
        {
            InitializeComponent();
            Width = InitWidth;
            Height = InitHeight;
            _drawingPanel.BackColor = Color.White;
        }

        private void InitGraph()
        {
            GenerateOrigin();
            GeneratePointConverter();
            _axis = new Axis(_drawingPanel, _origin);
            _scale = new Scale(_drawingPanel, _origin, InitScaleSize);
        }

        private void GeneratePointConverter()
        {
            _pointConverter = new PointConverter(PanelWidth, PanelHeight);
        }

        private void GenerateOrigin()
        {
            _origin = new GraphPoint(PanelLeftMargin, PanelTopMargin);
        }

        private Graphics GenerateDrawingGraphics()
        {
            return _drawingPanel.CreateGraphics();
        }

        private static RealPoint ApplyScale(Point p)
        {
            return new RealPoint((double)p.X / InitScaleSize, (double)p.Y / InitScaleSize);
        }

        private void PrintMousePointerPosition(Point mousePointerPosition)
        {
            var realPoint = ApplyScale(mousePointerPosition);
            mousePointerPositionLabel.Text = string.Format("(X;Y) = ({0};{1})", realPoint.X, realPoint.Y);
        }
    }
}
