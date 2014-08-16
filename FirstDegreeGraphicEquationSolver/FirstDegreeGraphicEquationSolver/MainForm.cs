namespace FirstDegreeGraphicEquationSolver
{
    using Drawers;
    using Objects;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using Tools;
    using PanelPointConverter = Tools.PointConverter;

    public partial class MainForm : Form
    {
        private const int InitWidth = 800;
        private const int InitHeight = 600;
        private int _pixelsPerScaleUnit = 10;

        private Graphics _drawingPanelGraphics;

        private Scale _scale;
        private GraphPoint _origin;
        private Axis _axis;
        private AxisDrawer _axisDrawer;
        private ScaleDrawer _scaleDrawer;
        private GraphLineDrawer _graphLineDrawer;
        private PanelPointConverter _pointConverter;

        private readonly FirstDegreeEquationExpressionParser _equationParser = new FirstDegreeEquationExpressionParser();
        private readonly List<GraphLine> _lines = new List<GraphLine>();
        private readonly List<GraphLine> _pointedLines = new List<GraphLine>();

        private ListBox _equationListBox;
        private TextBox _equationTextBox;

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

        private void RedrawPointedLines(Point mousePosition)
        {
            GetPointedLines(mousePosition);
            DrawLines(_lines, Pens.Black);
            DrawLines(_pointedLines, Pens.DeepPink);
        }

        private void GetPointedLines(Point mousePointerPosition)
        {
            _pointedLines.Clear();

            var point = _drawingPanel.PointToClient(mousePointerPosition);
            var point2 = _pointConverter.ConvertToScreenCoords(point);
            _pointedLines.AddRange(_lines.Where(l => l.HasScreenCoordsPoint(point2, _scale.GetScaleFactor())).ToList());
        }

        private void AddInitEquation()
        {
            AddEquation("x+1");
        }

        private void AddEquation(string expression) 
        {
            var equation = _equationParser.Parse(expression);
            _lines.Add(new GraphLine(equation));
            _equationListBox.Items.Add(equation);
            RefreshLines();
        }

        private void DrawLines(IEnumerable<GraphLine> lines, Pen pen)
        {
            GeneratePointConverter();
            GenerateGraphLineDrawer();
            foreach (var line in lines)
            {
                _graphLineDrawer.Draw(_drawingPanelGraphics, line, pen, _scale.GetScaleFactor());
            }
        }

        private void InitForm()
        {
            InitializeComponent();
            Width = InitWidth;
            Height = InitHeight;
            _drawingPanel.BackColor = Color.White;
            CenterToScreen();
            _equationTextBox.Focus();
        }

        private void InitGraph()
        {
            GenerateScale();
            GenerateOrigin();
            GeneratePointConverter();
            _axis = new Axis(_drawingPanel, _origin);
            _axisDrawer = new AxisDrawer(_drawingPanel, _axis);
            _scaleDrawer = new ScaleDrawer(_drawingPanel, _origin, _scale);
            GenerateGraphLineDrawer();
        }

        private void GenerateGraphLineDrawer()
        {
            _graphLineDrawer = new GraphLineDrawer(_pointConverter);
        }

        private void GenerateScale()
        {
            _scale = new Scale(_pixelsPerScaleUnit, 1);
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
            var point = _drawingPanel.PointToClient(mousePointerPosition);
            var realPoint = _scale.Apply(_pointConverter.ConvertToScreenCoords(point));
            mousePointerPositionLabel.Text = string.Format(CultureInfo.CurrentCulture, "(X;Y) = ({0};{1})", realPoint.X, realPoint.Y);
        }

        private void RefreshLines()
        {
            _drawingPanel.Refresh();
            GenerateOrigin();
            GeneratePointConverter();
            GenerateDrawingGraphics();
            _axisDrawer.Draw(_drawingPanelGraphics, _origin);
            _scaleDrawer.Draw(_drawingPanelGraphics, _origin);
            DrawLines(_lines, Pens.Black); ;
        }

        #region Form events

        private void MainForm_Shown(object sender, EventArgs e)
        {
            GenerateDrawingGraphics();
            _axisDrawer.Draw(_drawingPanelGraphics);
            _scaleDrawer.Draw(_drawingPanelGraphics);
            AddInitEquation();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (_axis == null || _scale == null) return;

            RefreshLines();
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            PrintMousePointerPosition(Cursor.Position);
            RedrawPointedLines(Cursor.Position);
        }

        private void trackBarScale_ValueChanged(object sender, EventArgs e)
        {
            var trackBar = (TrackBar) sender;
            _pixelsPerScaleUnit = trackBar.Value * 10;

            GenerateScale();
            RefreshLines();
        }

        private void equationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                AddEquation((sender as TextBox).Text);
                _equationTextBox.Text = string.Empty;
            }
        }

        #endregion
    }
}
