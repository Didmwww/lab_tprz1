using System;

namespace PowerShellTerminal.Lab5
{
    public class Lab5CommandDemo
    {
        public static void Run()
        {
            var receiver = new TerminalActionReceiver();
            var invoker = new TerminalCommandInvoker();

            invoker.ExecuteCommand(new ExecutePowerShellCommand(receiver, "Get-Process"));
            invoker.ExecuteCommand(new RunExecutableCommand(receiver, "pwsh.exe", "-NoProfile"));
            invoker.ExecuteCommand(new CreateTabCommand(receiver, "Diagnostics Tab"));
            invoker.ExecuteCommand(new SplitPaneCommand(receiver, "Horizontal"));

            Console.WriteLine("--- Скасування останньої дії ---");
            invoker.UndoLastCommand();

            Console.WriteLine("--- Очищення екрана ---");
            invoker.ExecuteCommand(new ClearScreenCommand(receiver));
        }
    }
}
