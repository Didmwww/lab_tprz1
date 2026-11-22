namespace PowerShellTerminal.Lab6
{
    public class DarkWindowStyle : IWindowStyle
    {
        public string BackgroundColor => "#0C0C0C";
        public string ForegroundColor => "#F2F2F2";
        public int FontSize => 14;

        public string DescribeWindow()
        {
            return $"Вікно [Dark]: фон={BackgroundColor}, текст={ForegroundColor}, розмір шрифту={FontSize}";
        }
    }
}
