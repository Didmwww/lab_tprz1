using System;

namespace PowerShellTerminal.Lab5
{
    public class CreateTabCommand : ITerminalCommand
    {
        private readonly TerminalActionReceiver _receiver;
        private readonly string _tabTitle;

        public string CommandName => $"CreateTab: {_tabTitle}";

        public CreateTabCommand(TerminalActionReceiver receiver, string tabTitle)
        {
            _receiver = receiver ?? throw new ArgumentNullException(nameof(receiver));
            _tabTitle = string.IsNullOrWhiteSpace(tabTitle) ? "New Tab" : tabTitle;
        }

        public void Execute()
        {
            _receiver.OpenNewTab(_tabTitle);
        }

        public void Undo()
        {
            _receiver.RemoveLastTab();
        }
    }
}
