

namespace Test
{
    using System.Drawing;
    using FirstDegreeGraphicEquationSolver.Classes;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class GraphLineTest
    {
        [TestMethod]
        public void GivenXWhenGetYThenYIsCorrect()
        {
            var line = new GraphLine(new Point(0, 0), new Point(10, 20));

            Check.That(line.GetY(0)).Equals(0);
            Check.That(line.GetY(10)).Equals(20);
        }

        [TestMethod]
        public void GivenAbsolutePointOnThenLineWhenHasAbsolutePoinThenReturnTrue()
        {
            var line = new GraphLine(new Point(0, 0), new Point(10, 10));

            Check.That(line.HasAbsolutePoint(new Point(20, 20))).Equals(true);
        }
    }
}
