namespace PowerShellTerminal.Lab4
{
    public class ExecutionOutputData
    {
        public string CommandText { get; set; } = string.Empty;
        public string RawOutput { get; set; } = string.Empty;
        public string ErrorMessage { get; set; } = string.Empty;
        public bool IsSuccess => string.IsNullOrEmpty(ErrorMessage);
    }
}
