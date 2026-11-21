namespace PowerShellTerminal.Lab2
{
    public class TerminalSettings
    {
        public int Id { get; set; }
        public string ThemeName { get; set; } = "Default";
        public string BackgroundColor { get; set; } = "#012456";
        public string FontColor { get; set; } = "#FFFFFF";
        public string SyntaxKeywordColor { get; set; } = "#FFFF00";
        public int FontSize { get; set; } = 14;
    }
}
