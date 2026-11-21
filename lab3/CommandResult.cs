namespace PowerShellTerminal.Lab3
{
    public class CommandResult
    {
        public string Output { get; set; } = string.Empty;
        public string Error { get; set; } = string.Empty;
        public bool IsSuccess => string.IsNullOrEmpty(Error);
    }
}
