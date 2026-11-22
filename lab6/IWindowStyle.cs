namespace PowerShellTerminal.Lab6
{
    public interface IWindowStyle
    {
        string BackgroundColor { get; }
        string ForegroundColor { get; }
        int FontSize { get; }
        string DescribeWindow();
    }
}
