namespace IST.RRHH.Domain.Utilidades
{
    public enum ParameterVariablesTipo
    {
        DateTime,
        Varchar,
        Int,
        Decimal,
    }
    public class ParameterVariables
    {
        public string Variable { get; set; }

        public ParameterVariablesTipo Tipo { get; set; }

        public string Value { get; set; }
    }
}