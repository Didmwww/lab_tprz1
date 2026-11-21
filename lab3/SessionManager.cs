using System;
using System.Collections.Generic;

namespace PowerShellTerminal.Lab3
{
    public class SessionManager
    {
        private readonly List<string> _tabs = new List<string> { "Tab 1 (Default)" };

        public void AddTab(string title)
        {
            _tabs.Add(title);
            Console.WriteLine($"Відкрито нову вкладку: {title}. Активних вкладок: {_tabs.Count}");
        }

        public void SplitPane(string layout)
        {
            Console.WriteLine($"Екран розділено у режимі: {layout}");
        }
    }
}
