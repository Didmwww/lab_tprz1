namespace PowerShellTerminal.Lab6
{
    public interface IPaneLayoutStyle
    {
        string ActiveTabStyle { get; }
        string SplitDividerStyle { get; }
        string DescribeLayout();
    }
}
