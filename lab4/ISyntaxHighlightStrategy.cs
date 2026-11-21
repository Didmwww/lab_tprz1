namespace PowerShellTerminal.Lab4
{
    public interface ISyntaxHighlightStrategy
    {
        string StrategyName { get; }
        string Highlight(string commandLine);
    }
}
