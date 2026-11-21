using System;

namespace PowerShellTerminal.Lab5
{
    public class ClearScreenCommand : ITerminalCommand
    {
        private readonly TerminalActionReceiver _receiver;

        public string CommandName => "ClearScreen";

        public ClearScreenCommand(TerminalActionReceiver receiver)
        {
            _receiver = receiver ?? throw new ArgumentNullException(nameof(receiver));
        }

        public void Execute()
        {
            _receiver.ClearScreen();
        }

        public void Undo()
        {
            Console.WriteLine("[UNDO] Попередній буфер екрана відновлено частково");
        }
    }
}
