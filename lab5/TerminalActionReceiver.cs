using System;
using System.Collections.Generic;

namespace PowerShellTerminal.Lab5
{
    public class TerminalActionReceiver
    {
        private readonly List<string> _tabs = new List<string> { "Main Tab" };
        private readonly List<string> _screenLines = new List<string>();

        public void RunPowerShellCommand(string commandText)
        {
            string line = $"[PS] Виконано: {commandText}";
            _screenLines.Add(line);
            Console.WriteLine(line);
        }

        public void LaunchExecutable(string exePath, string arguments)
        {
            string line = $"[EXE] Запущено '{exePath}' з аргументами '{arguments}'";
            _screenLines.Add(line);
            Console.WriteLine(line);
        }

        public void OpenNewTab(string tabTitle)
        {
            _tabs.Add(tabTitle);
            Console.WriteLine($"[TAB] Відкрито вкладку '{tabTitle}'. Всього вкладок: {_tabs.Count}");
        }

        public void RemoveLastTab()
        {
            if (_tabs.Count > 1)
            {
                string removed = _tabs[_tabs.Count - 1];
                _tabs.RemoveAt(_tabs.Count - 1);
                Console.WriteLine($"[TAB] Закрито вкладку '{removed}'. Всього вкладок: {_tabs.Count}");
            }
        }

        public void SplitScreen(string orientation)
        {
            Console.WriteLine($"[SPLIT] Екран розділено ({orientation})");
        }

        public void ClearScreen()
        {
            _screenLines.Clear();
            Console.WriteLine("[SCREEN] Екран терміналу очищено");
        }
    }
}
