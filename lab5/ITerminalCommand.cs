namespace PowerShellTerminal.Lab5
{
    public interface ITerminalCommand
    {
        string CommandName { get; }
        void Execute();
        void Undo();
    }
}
