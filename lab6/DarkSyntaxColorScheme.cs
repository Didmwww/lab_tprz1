namespace PowerShellTerminal.Lab6
{
    public class DarkSyntaxColorScheme : ISyntaxColorScheme
    {
        public string CmdletColor => "#569CD6";
        public string ParameterColor => "#9CDCFE";
        public string ErrorColor => "#F14C4C";

        public string DescribeSyntaxColors()
        {
            return $"Синтаксис [Dark]: командлети={CmdletColor}, параметри={ParameterColor}, помилки={ErrorColor}";
        }
    }
}
