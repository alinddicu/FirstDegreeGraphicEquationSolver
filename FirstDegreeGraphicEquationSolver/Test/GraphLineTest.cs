

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
        public void TestMethod1()
        {
            var line = new GraphLine(new Point(0, 0), new Point(10, 20));

            Check.That(line.GetY(0)).Equals(0);
            Check.That(line.GetY(10)).Equals(20);
        }
    }
}
