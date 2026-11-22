namespace PowerShellTerminal.Lab6
{
    public class LightThemeTerminalFactory : ITerminalThemeFactory
    {
        public string ThemeName => "Light Theme";

        public IWindowStyle CreateWindowStyle() => new LightWindowStyle();
        public ISyntaxColorScheme CreateSyntaxColorScheme() => new LightSyntaxColorScheme();
        public IPaneLayoutStyle CreatePaneLayoutStyle() => new LightPaneLayoutStyle();
    }
}
