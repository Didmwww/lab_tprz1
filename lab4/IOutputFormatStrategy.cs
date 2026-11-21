namespace PowerShellTerminal.Lab4
{
    public interface IOutputFormatStrategy
    {
        string FormatterName { get; }
        string Format(ExecutionOutputData data);
    }
}
