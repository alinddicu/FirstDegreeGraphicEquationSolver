namespace Test
{
    using FirstDegreeGraphicEquationSolver.Objects;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class FirstDegreeEquationTest
    {
        private FirstDegreeEquation _equation;

        [TestMethod]
        public void WhenEquationIsXThenBehaviourIsCorrect()
        {
            _equation = new FirstDegreeEquation(1, 0);

            Check.That(_equation.A).Equals(1.0);
            Check.That(_equation.B).Equals(0.0);
            Check.That(_equation.ToString()).Equals("f(x) = x");
            Check.That(_equation.GetY(0)).Equals(0.0);
            Check.That(_equation.GetY(1)).Equals(1.0);
        }

        [TestMethod]
        public void WhenEquationIs2XMinus2ThenBehaviourIsCorrect()
        {
            _equation = new FirstDegreeEquation(2, -2);

            Check.That(_equation.A).Equals(2.0);
            Check.That(_equation.B).Equals(-2.0);
            Check.That(_equation.ToString()).Equals("f(x) = 2*x-2");
            Check.That(_equation.GetY(0)).Equals(-2.0);
            Check.That(_equation.GetY(1)).Equals(0.0);
        }
    }
}
