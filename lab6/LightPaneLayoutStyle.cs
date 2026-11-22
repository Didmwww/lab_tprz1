namespace PowerShellTerminal.Lab6
{
    public class LightPaneLayoutStyle : IPaneLayoutStyle
    {
        public string ActiveTabStyle => "Світла вкладка з акцентною рамкою";
        public string SplitDividerStyle => "Тонка лінія розділення (#CCCCCC)";

        public string DescribeLayout()
        {
            return $"Вкладки/Split [Light]: {ActiveTabStyle}, розділювач='{SplitDividerStyle}'";
        }
    }
}
