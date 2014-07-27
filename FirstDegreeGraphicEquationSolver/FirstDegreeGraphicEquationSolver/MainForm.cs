using System.Globalization;

namespace FirstDegreeGraphicEquationSolver
{
    using Classes;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using PanelPointConverter = Classes.PointConverter;

    public partial class MainForm : Form
    {
        private const int InitWidth = 800;
        private const int InitHeight = 600;
        private const int InitScaleSize = 10;

        private Graphics _drawingPanelGraphics;

        private GraphPoint _origin;
        private Axis _axis;
        private Scale _scale;
        private PanelPointConverter _pointConverter;
        private readonly List<GraphLine> _lines = new List<GraphLine>();

        public MainForm()
        {
            InitForm();
            InitGraph();
        }

        #region Properties

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

        #endregion

        #region Form events

        private void MainForm_Shown(object sender, EventArgs e)
        {
            GenerateDrawingGraphics();
            _axis.Draw(_drawingPanelGraphics);
            _scale.Draw(_drawingPanelGraphics);
            AddTestsLines();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (_axis == null || _scale == null) return;

            _drawingPanel.Refresh();
            GenerateOrigin();
            GeneratePointConverter();
            GenerateDrawingGraphics();
            _axis.Draw(_drawingPanelGraphics, _origin);
            _scale.Draw(_drawingPanelGraphics, _origin);
            AddTestsLines();
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            var point = _drawingPanel.PointToClient(Cursor.Position);
            PrintMousePointerPosition(_pointConverter.ConvertToAbsoluteCoords(point));
        }

        #endregion

        private void AddTestsLines()
        {
            _lines.Clear();
            _lines.Add(new GraphLine(new Point(0, 0), new Point(10, 10)));
            _lines.Add(new GraphLine(new Point(0, 0), new Point(10, 20)));
            _lines.Add(new GraphLine(new Point(0, 10), new Point(10, 20)));
            _lines.Add(new GraphLine(new Point(0, 10), new Point(10, 10)));

            DrawTestLines();
        }

        private void DrawTestLines()
        {
            GeneratePointConverter();
            GenerateDrawingGraphics();
            foreach (var line in _lines)
            {
                line.Draw(_drawingPanelGraphics, Pens.Black, _pointConverter);
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
            _pointConverter = new PanelPointConverter(_origin);
        }

        private void GenerateOrigin()
        {
            _origin = new GraphPoint(PanelLeftMargin, PanelTopMargin);
        }

        private void GenerateDrawingGraphics()
        {
            _drawingPanelGraphics = _drawingPanel.CreateGraphics();
        }

        private void PrintMousePointerPosition(Point mousePointerPosition)
        {
            var realPoint = _scale.ApplyScale(mousePointerPosition);
            mousePointerPositionLabel.Text = string.Format(CultureInfo.CurrentCulture, "(X;Y) = ({0};{1})", realPoint.X, realPoint.Y);
        }
    }
}
