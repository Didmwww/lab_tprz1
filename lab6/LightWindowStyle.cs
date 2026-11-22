namespace PowerShellTerminal.Lab6
{
    public class LightWindowStyle : IWindowStyle
    {
        public string BackgroundColor => "#FFFFFF";
        public string ForegroundColor => "#1E1E1E";
        public int FontSize => 14;

        public string DescribeWindow()
        {
            return $"Вікно [Light]: фон={BackgroundColor}, текст={ForegroundColor}, розмір шрифту={FontSize}";
        }
    }
}
