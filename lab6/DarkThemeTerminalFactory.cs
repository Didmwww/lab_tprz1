namespace PowerShellTerminal.Lab6
{
    public class DarkThemeTerminalFactory : ITerminalThemeFactory
    {
        public string ThemeName => "Dark Theme";

        public IWindowStyle CreateWindowStyle() => new DarkWindowStyle();
        public ISyntaxColorScheme CreateSyntaxColorScheme() => new DarkSyntaxColorScheme();
        public IPaneLayoutStyle CreatePaneLayoutStyle() => new DarkPaneLayoutStyle();
    }
}
