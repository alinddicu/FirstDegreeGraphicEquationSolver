namespace Test
{
    using FirstDegreeGraphicEquationSolver.Tools;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class FirstDegreeEquationExpressionTest
    {
        private FirstDegreeEquationExpressionParser _parser = new FirstDegreeEquationExpressionParser();

        [TestMethod]
        public void TestX()
        {
            var equation = _parser.Parse("x");
            Check.That(equation.GetY(0)).Equals(0.0);
            Check.That(equation.GetY(1)).Equals(1.0);
        }

        [TestMethod]
        public void Test2X()
        {
            var equation = _parser.Parse("2x");
            Check.That(equation.GetY(0)).Equals(0.0);
            Check.That(equation.GetY(1)).Equals(2.0);
        }

        [TestMethod]
        public void Test2Point1X()
        {
            var equation = _parser.Parse("2.1x");
            Check.That(equation.GetY(0)).Equals(0.0);
            Check.That(equation.GetY(1)).Equals(2.1);
        }

        [TestMethod]
        public void Test2Point1XPlus2Point1()
        {
            var equation = _parser.Parse("2.1x+2.1");
            Check.That(equation.GetY(0)).Equals(2.1);
            Check.That(equation.GetY(1)).Equals(4.2);
        }

        [TestMethod]
        public void TestMinus2Point1XMinus2Point1()
        {
            var equation = _parser.Parse("-2.1x-2.1");
            Check.That(equation.GetY(0)).Equals(-2.1);
            Check.That(equation.GetY(1)).Equals(-4.2);
        }

        [TestMethod]
        public void TestPlusX()
        {
            var equation = _parser.Parse("+x");
            Check.That(equation.GetY(0)).Equals(0.0);
            Check.That(equation.GetY(1)).Equals(1.0);
        }

        [TestMethod]
        public void TestMinusX()
        {
            var equation = _parser.Parse("-x");
            Check.That(equation.GetY(0)).Equals(0.0);
            Check.That(equation.GetY(1)).Equals(-1.0);
        }

        [TestMethod]
        public void TestXPlus1()
        {
            var equation = _parser.Parse("x+1");
            Check.That(equation.GetY(0)).Equals(1.0);
            Check.That(equation.GetY(1)).Equals(2.0);
        }

        [TestMethod]
        public void TestXMinus1()
        {
            var equation = _parser.Parse("x-1");
            Check.That(equation.GetY(0)).Equals(-1.0);
            Check.That(equation.GetY(1)).Equals(0.0);
        }

        [TestMethod]
        public void Test2XPlus1()
        {
            var equation = _parser.Parse("2.1x+1");
            Check.That(equation.GetY(0)).Equals(1.0);
            Check.That(equation.GetY(1)).Equals(3.1);
        }

        [TestMethod]
        public void TestXaab()
        {
            //var equation = _parser.Extract("xaab");
            //Check.ThatCode(() => equation.GetY(0)).;
        }

        //[TestMethod]
        //public void TestPlusMinusX()
        //{
        //    // Check.That(_parser.CanParse("+-x")).Equals(false);
        //}

        //[TestMethod]
        //public void Test2Point1XPlus2PointPlus()
        //{
        //    // Check.That(_parser.CanParse("2.1x+2.1+")).Equals(false);
        //}
    }
}
