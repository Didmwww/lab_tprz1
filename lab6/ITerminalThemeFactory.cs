namespace PowerShellTerminal.Lab6
{
    public interface ITerminalThemeFactory
    {
        string ThemeName { get; }
        IWindowStyle CreateWindowStyle();
        ISyntaxColorScheme CreateSyntaxColorScheme();
        IPaneLayoutStyle CreatePaneLayoutStyle();
    }
}
