using FirstDegreeGraphicEquationSolver.Objects;
using FirstDegreeGraphicEquationSolver.Tools;
using NFluent;

namespace Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Drawing;
    using PointConverter = PointConverter;

    [TestClass]
    public class PointConverterTest
    {
        private PointConverter _pointConverter = null;

        [TestMethod]
        public void WhenConvertToPanelCoordsThenNewCoordsAreOk()
        {
            var origin = new Point(1, 2);
            var point = new Point(1, 1);

            _pointConverter = new PointConverter(origin);
            var converted = _pointConverter.ConvertToPanelCoords(point);
            Check.That(converted.X).Equals(origin.X + point.X);
            Check.That(converted.Y).Equals(origin.Y - point.Y);
        }

        [TestMethod]
        public void WhenConvertToAbsoluteCoordsThenNewCoordsAreOk()
        {
            var origin = new Point(1, 1);
            var point = new Point(1, 1);

            _pointConverter = new PointConverter(origin);
            var converted = _pointConverter.ConvertToScreenCoords(point);
            Check.That(converted.X).Equals(-origin.X + point.X);
            Check.That(converted.Y).Equals(origin.Y - point.Y);
        }
    }
}
