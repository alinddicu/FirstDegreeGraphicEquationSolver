namespace Test
{
    using FirstDegreeGraphicEquationSolver.Objects;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;
    using System.Drawing;

    [TestClass]
    public class ScaleTest
    {
        public const int HalfScaleBatonnetWidth = 1;

        private Scale _scale;

        [TestMethod]
        public void GivenScaleWhenGetScaleFactorThenScaleFactorIsCorrect()
        {
            _scale = new Scale(10, HalfScaleBatonnetWidth, 5);

            Check.That(_scale.GetScaleFactor()).Equals(10/5);
        }

        [TestMethod]
        public void GivenScaleWhenApplyThenScaledPointIsCorrect()
        {
            _scale = new Scale(10, HalfScaleBatonnetWidth, 5);
            var scaleFactor = 10 / 5;
            var point = new Point(100, 20);
            var returnPoint = _scale.Apply(point);

            Check.That(returnPoint.X).Equals((double)point.X/scaleFactor);
            Check.That(returnPoint.Y).Equals((double)point.Y / scaleFactor);
        }
    }
}
