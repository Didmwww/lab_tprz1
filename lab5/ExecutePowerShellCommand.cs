using System;

namespace PowerShellTerminal.Lab5
{
    public class ExecutePowerShellCommand : ITerminalCommand
    {
        private readonly TerminalActionReceiver _receiver;
        private readonly string _commandText;

        public string CommandName => $"PowerShell: {_commandText}";

        public ExecutePowerShellCommand(TerminalActionReceiver receiver, string commandText)
        {
            _receiver = receiver ?? throw new ArgumentNullException(nameof(receiver));
            _commandText = commandText ?? string.Empty;
        }

        public void Execute()
        {
            _receiver.RunPowerShellCommand(_commandText);
        }

        public void Undo()
        {
            Console.WriteLine($"[UNDO] Скасування для PowerShell-команди '{_commandText}' не застосовується автоматично");
        }
    }
}
