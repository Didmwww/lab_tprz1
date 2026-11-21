using System;

namespace PowerShellTerminal.Lab3
{
    public class CommandExecutor
    {
        private readonly ISyntaxHighlighter _highlighter;

        public CommandExecutor(ISyntaxHighlighter highlighter)
        {
            _highlighter = highlighter;
        }

        public CommandResult Execute(string command, string themeColor)
        {
            _highlighter.RenderHighlighted(command, themeColor);
            if (string.IsNullOrWhiteSpace(command))
            {
                return new CommandResult { Error = "Порожня команда" };
            }

            return new CommandResult { Output = $"Виконано PowerShell команду: {command}" };
        }
    }
}
