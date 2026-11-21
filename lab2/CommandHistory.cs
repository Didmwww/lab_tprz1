using System;

namespace PowerShellTerminal.Lab2
{
    public class CommandHistory
    {
        public int Id { get; set; }
        public string CommandText { get; set; } = string.Empty;
        public DateTime ExecutedAt { get; set; }
        public bool IsSuccessful { get; set; }
    }
}
