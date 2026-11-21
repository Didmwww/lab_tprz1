using System;

namespace PowerShellTerminal.Lab5
{
    public class SplitPaneCommand : ITerminalCommand
    {
        private readonly TerminalActionReceiver _receiver;
        private readonly string _orientation;

        public string CommandName => $"SplitPane: {_orientation}";

        public SplitPaneCommand(TerminalActionReceiver receiver, string orientation)
        {
            _receiver = receiver ?? throw new ArgumentNullException(nameof(receiver));
            _orientation = string.IsNullOrWhiteSpace(orientation) ? "Vertical" : orientation;
        }

        public void Execute()
        {
            _receiver.SplitScreen(_orientation);
        }

        public void Undo()
        {
            Console.WriteLine($"[UNDO] Знято поділ екрана ({_orientation})");
        }
    }
}
