namespace PowerShellTerminal.Lab6
{
    public class LightSyntaxColorScheme : ISyntaxColorScheme
    {
        public string CmdletColor => "#0000FF";
        public string ParameterColor => "#0070C1";
        public string ErrorColor => "#CD3131";

        public string DescribeSyntaxColors()
        {
            return $"Синтаксис [Light]: командлети={CmdletColor}, параметри={ParameterColor}, помилки={ErrorColor}";
        }
    }
}
