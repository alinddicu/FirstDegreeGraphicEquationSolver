namespace FirstDegreeGraphicEquationSolver.DataAccess
{
    using FirstDegreeGraphicEquationSolver.Objects;

    public class EquationListItem
    {
        public bool Selected { get; set; }

        public FirstDegreeEquation Equation { get; set; }

        public bool Highlighted { get; set; }
    }
}
