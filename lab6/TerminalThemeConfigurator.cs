using System;

namespace PowerShellTerminal.Lab6
{
    public class TerminalThemeConfigurator
    {
        private readonly ITerminalThemeFactory _factory;

        public TerminalThemeConfigurator(ITerminalThemeFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        public void ApplyTheme()
        {
            var windowStyle = _factory.CreateWindowStyle();
            var syntaxScheme = _factory.CreateSyntaxColorScheme();
            var paneLayout = _factory.CreatePaneLayoutStyle();

            Console.WriteLine($"=== Застосовано: {_factory.ThemeName} ===");
            Console.WriteLine(windowStyle.DescribeWindow());
            Console.WriteLine(syntaxScheme.DescribeSyntaxColors());
            Console.WriteLine(paneLayout.DescribeLayout());
        }
    }
}
