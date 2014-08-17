

namespace Test
{
    using FirstDegreeGraphicEquationSolver.Objects;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;
    using System.Drawing;

    [TestClass]
    public class GraphLineTest
    {
        private const int _scaleFactor = 1;

        [TestMethod]
        public void GivenXWhenGetYThenYIsCorrect()
        {
            var line = new GraphLine(new FirstDegreeEquation(2.0, 0.0));

            Check.That(line.GetY(0, _scaleFactor)).Equals(0);
            Check.That(line.GetY(10, _scaleFactor)).Equals(20);
        }

        [TestMethod]
        public void GivenAbsolutePointOnThenLineWhenHasAbsolutePoinThenReturnTrue()
        {
            var line = new GraphLine(new FirstDegreeEquation(2.0, 0.0));

            Check.That(line.HasScreenCoordsPoint(new Point(20, 40), _scaleFactor)).Equals(true);
        }
    }
}
