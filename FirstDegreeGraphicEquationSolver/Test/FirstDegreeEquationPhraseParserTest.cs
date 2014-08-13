namespace Test
{
    using FirstDegreeGraphicEquationSolver.Tools;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class FirstDegreeEquationPhraseParserTest
    {
        private FirstDegreeEquationPhraseParser _parser = new FirstDegreeEquationPhraseParser();

        [TestMethod]
        public void TestX()
        {
            Check.That(_parser.CanParse("x")).Equals(true);
            Check.That(_parser.Extract("x")).ContainsExactly(new[] { 1.0, 0.0 });
        }

        [TestMethod]
        public void Test2X()
        {
            Check.That(_parser.CanParse("2x")).Equals(true);
            Check.That(_parser.Extract("2x")).ContainsExactly(new[] { 2.0, 0.0 });
        }

        [TestMethod]
        public void Test2Point1X()
        {
            Check.That(_parser.CanParse("2.1x")).Equals(true);
            Check.That(_parser.Extract("2.1x")).ContainsExactly(new[] { 2.1, 0.0 });
        }

        [TestMethod]
        public void Test2Point1XPlus2Point1()
        {
            Check.That(_parser.CanParse("2.1x+2.1")).Equals(true);
            Check.That(_parser.Extract("2.1x+2.1")).ContainsExactly(new[] { 2.1, 2.1 });
        }

        [TestMethod]
        public void TestMinus2Point1XMinus2Point1()
        {
            Check.That(_parser.CanParse("-2.1x-2.1")).Equals(true);
            Check.That(_parser.Extract("-2.1x-2.1")).ContainsExactly(new[] { -2.1, -2.1 });
        }

        [TestMethod]
        public void TestPlusX()
        {
            Check.That(_parser.CanParse("+x")).Equals(true);
        }

        [TestMethod]
        public void TestMinusX()
        {
            Check.That(_parser.CanParse("-x")).Equals(true);
            Check.That(_parser.Extract("-x")).ContainsExactly(new[] { -1.0, 0.0 });
        }

        [TestMethod]
        public void TestXPlus1()
        {
            Check.That(_parser.CanParse("x+1")).Equals(true);
        }

        [TestMethod]
        public void TestXMinus1()
        {
            Check.That(_parser.CanParse("x-1")).Equals(true);
        }

        [TestMethod]
        public void Test2XPlus1()
        {
            Check.That(_parser.CanParse("2x+1")).Equals(true);
        }

        [TestMethod]
        public void TestXaab()
        {
            Check.That(_parser.CanParse("xaab")).Equals(false);
        }

        [TestMethod]
        public void TestPlusMinusX()
        {
            Check.That(_parser.CanParse("+-x")).Equals(false);
        }

        [TestMethod]
        public void Test2Point1XPlus2PointPlus()
        {
            Check.That(_parser.CanParse("2.1x+2.1+")).Equals(false);
        }
    }
}
