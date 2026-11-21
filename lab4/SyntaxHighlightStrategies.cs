namespace PowerShellTerminal.Lab4
{
    public class DarkPowerShellHighlightStrategy : ISyntaxHighlightStrategy
    {
        public string StrategyName => "Dark PowerShell Syntax";

        public string Highlight(string commandLine)
        {
            return $"[DARK | Cmdlet/Param Highlight] {commandLine}";
        }
    }

    public class LightPowerShellHighlightStrategy : ISyntaxHighlightStrategy
    {
        public string StrategyName => "Light PowerShell Syntax";

        public string Highlight(string commandLine)
        {
            return $"[LIGHT | High-Contrast Syntax] {commandLine}";
        }
    }

    public class PlainTextHighlightStrategy : ISyntaxHighlightStrategy
    {
        public string StrategyName => "Plain Text Syntax";

        public string Highlight(string commandLine)
        {
            return $"[PLAIN] {commandLine}";
        }
    }
}
