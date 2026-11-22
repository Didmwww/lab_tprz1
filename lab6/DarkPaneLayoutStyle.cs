namespace PowerShellTerminal.Lab6
{
    public class DarkPaneLayoutStyle : IPaneLayoutStyle
    {
        public string ActiveTabStyle => "Темна вкладка з блакитним індикатором";
        public string SplitDividerStyle => "Тонка лінія розділення (#333333)";

        public string DescribeLayout()
        {
            return $"Вкладки/Split [Dark]: {ActiveTabStyle}, розділювач='{SplitDividerStyle}'";
        }
    }
}
