namespace PowerShellTerminal.Lab6
{
    public interface ISyntaxColorScheme
    {
        string CmdletColor { get; }
        string ParameterColor { get; }
        string ErrorColor { get; }
        string DescribeSyntaxColors();
    }
}
