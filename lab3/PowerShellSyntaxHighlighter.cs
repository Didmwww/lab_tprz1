using System;

namespace PowerShellTerminal.Lab3
{
    public class PowerShellSyntaxHighlighter : ISyntaxHighlighter
    {
        public void RenderHighlighted(string text, string themeColor)
        {
            Console.WriteLine($"[Syntax:{themeColor}] {text}");
        }
    }
}
