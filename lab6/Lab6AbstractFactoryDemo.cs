using System;

namespace PowerShellTerminal.Lab6
{
    public class Lab6AbstractFactoryDemo
    {
        public static void Run()
        {
            var darkConfigurator = new TerminalThemeConfigurator(new DarkThemeTerminalFactory());
            darkConfigurator.ApplyTheme();

            Console.WriteLine();

            var lightConfigurator = new TerminalThemeConfigurator(new LightThemeTerminalFactory());
            lightConfigurator.ApplyTheme();
        }
    }
}
