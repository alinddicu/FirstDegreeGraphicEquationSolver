namespace FirstDegreeGraphicEquationSolver.Tools
{
    using FirstDegreeGraphicEquationSolver.Objects;
    using System.Globalization;
    using System.IO;
    using System.Text.RegularExpressions;

    public class FirstDegreeEquationExpressionParser
    {
        // (+/-)ax(+/-)b
        private static readonly Regex VerifyExpressionRegex = new Regex(@"^(\+?|\-?)(\d*)(\.?)(\d*)(x)(\+?|\-?)(\d*)(\.?)(\d*)$");
        private static readonly CultureInfo FormatProvider = new CultureInfo("en-US");

        private bool CanParse(string expression)
        {
            return VerifyExpressionRegex.IsMatch(expression);
        }

        public FirstDegreeEquation Extract(string expression)
        {
            if (!CanParse(expression))
            {
                throw new InvalidDataException(string.Format("First degree equation expression invalid '{0}'", expression));
            }

            var splits = expression.Split('x');
            var a = double.Parse(PreConvertA(splits[0]), FormatProvider);
            var b = double.Parse(PreConvertB(splits[1]), FormatProvider);

            return new FirstDegreeEquation(a, b);
        }

        private string PreConvertA(string splitA)
        {
            if (string.IsNullOrEmpty(splitA) || splitA == "+")
            {
                return "1";
            }

            if (splitA == "-")
            {
                return "-1";
            }

            return splitA;
        }

        private string PreConvertB(string splitB)
        {
            if (string.IsNullOrEmpty(splitB))
            {
                return "0";
            }

            return splitB;
        }
    }
}
