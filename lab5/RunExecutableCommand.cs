using System;

namespace PowerShellTerminal.Lab5
{
    public class RunExecutableCommand : ITerminalCommand
    {
        private readonly TerminalActionReceiver _receiver;
        private readonly string _exePath;
        private readonly string _arguments;

        public string CommandName => $"Executable: {_exePath}";

        public RunExecutableCommand(TerminalActionReceiver receiver, string exePath, string arguments = "")
        {
            _receiver = receiver ?? throw new ArgumentNullException(nameof(receiver));
            _exePath = exePath ?? string.Empty;
            _arguments = arguments ?? string.Empty;
        }

        public void Execute()
        {
            _receiver.LaunchExecutable(_exePath, _arguments);
        }

        public void Undo()
        {
            Console.WriteLine($"[UNDO] Завершення зовнішнього процесу '{_exePath}' потрібно виконувати вручну");
        }
    }
}
