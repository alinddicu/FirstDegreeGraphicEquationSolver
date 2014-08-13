namespace FirstDegreeGraphicEquationSolver.Tools
{
    using System.Globalization;
    using System.Text.RegularExpressions;

    public class FirstDegreeEquationPhraseParser
    {
        // (+/-)ax(+/-)b
        private static readonly Regex VerifyPhraseRegex = new Regex(@"^(\+?|\-?)(\d*)(\.?)(\d*)(x)(\+?|\-?)(\d*)(\.?)(\d*)$");
        private static readonly Regex ExtractRegex = new Regex(@"^(?<a>\+?|\-?\d*\.d*)x(?<b>\+?|\-?\d*\.d*)$");
        private static readonly CultureInfo FormatProvider = new CultureInfo("en-US");

        public bool CanParse(string phrase)
        {
            return VerifyPhraseRegex.IsMatch(phrase);
        }

        public double[] Extract(string phrase)
        {
            var match = ExtractRegex.Match(phrase);
            var aMatchValue = match.Groups["a"].Value;
            var bMatchValue = match.Groups["b"].Value;
            var a = double.Parse(string.IsNullOrEmpty(aMatchValue) ? "1" : aMatchValue, FormatProvider);
            var b = double.Parse(string.IsNullOrEmpty(bMatchValue) ? "0" : bMatchValue, FormatProvider);

            return new[] { a, b };
        }
    }
}
