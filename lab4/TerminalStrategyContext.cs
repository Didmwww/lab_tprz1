using System;

namespace PowerShellTerminal.Lab4
{
    public class TerminalStrategyContext
    {
        private ISyntaxHighlightStrategy _syntaxStrategy;
        private IOutputFormatStrategy _outputStrategy;

        public TerminalStrategyContext(
            ISyntaxHighlightStrategy syntaxStrategy,
            IOutputFormatStrategy outputStrategy)
        {
            _syntaxStrategy = syntaxStrategy ?? throw new ArgumentNullException(nameof(syntaxStrategy));
            _outputStrategy = outputStrategy ?? throw new ArgumentNullException(nameof(outputStrategy));
        }

        public void SetSyntaxStrategy(ISyntaxHighlightStrategy strategy)
        {
            _syntaxStrategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
        }

        public void SetOutputStrategy(IOutputFormatStrategy strategy)
        {
            _outputStrategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
        }

        public string PrepareCommandPreview(string commandLine)
        {
            return _syntaxStrategy.Highlight(commandLine);
        }

        public string RenderExecutionResult(ExecutionOutputData data)
        {
            return _outputStrategy.Format(data);
        }
    }

    public class Lab4StrategyDemo
    {
        public static void Run()
        {
            var context = new TerminalStrategyContext(
                new DarkPowerShellHighlightStrategy(),
                new DetailedOutputStrategy());

            string cmd = "Get-ChildItem -Path C:\\Projects";
            Console.WriteLine(context.PrepareCommandPreview(cmd));

            var sampleResult = new ExecutionOutputData
            {
                CommandText = cmd,
                RawOutput = "Mode: d-----  Name: PowerShellTerminal"
            };
            Console.WriteLine(context.RenderExecutionResult(sampleResult));

            context.SetSyntaxStrategy(new LightPowerShellHighlightStrategy());
            context.SetOutputStrategy(new CompactOutputStrategy());

            Console.WriteLine(context.PrepareCommandPreview(cmd));
            Console.WriteLine(context.RenderExecutionResult(sampleResult));
        }
    }
}
