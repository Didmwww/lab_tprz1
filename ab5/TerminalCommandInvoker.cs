using System;
using System.Collections.Generic;

namespace PowerShellTerminal.Lab5
{
    public class TerminalCommandInvoker
    {
        private readonly List<ITerminalCommand> _history = new List<ITerminalCommand>();

        public IReadOnlyList<ITerminalCommand> History => _history;

        public void ExecuteCommand(ITerminalCommand command)
        {
            if (command == null) throw new ArgumentNullException(nameof(command));
            command.Execute();
            _history.Add(command);
        }

        public void UndoLastCommand()
        {
            if (_history.Count == 0)
            {
                Console.WriteLine("[INVOKER] Немає команд для скасування");
                return;
            }

            var lastCommand = _history[_history.Count - 1];
            _history.RemoveAt(_history.Count - 1);
            lastCommand.Undo();
        }

        public void ReplayAll()
        {
            Console.WriteLine("[INVOKER] Повторне відтворення послідовності команд:");
            foreach (var cmd in _history)
            {
                cmd.Execute();
            }
        }
    }
}
