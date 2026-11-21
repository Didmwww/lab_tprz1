namespace PowerShellTerminal.Lab4
{
    public class DetailedOutputStrategy : IOutputFormatStrategy
    {
        public string FormatterName => "Detailed Output";

        public string Format(ExecutionOutputData data)
        {
            if (!data.IsSuccess)
            {
                return $"[ERROR] Команда: '{data.CommandText}' | Помилка: {data.ErrorMessage}";
            }
            return $"[SUCCESS] Команда: '{data.CommandText}' | Результат: {data.RawOutput}";
        }
    }

    public class CompactOutputStrategy : IOutputFormatStrategy
    {
        public string FormatterName => "Compact Output";

        public string Format(ExecutionOutputData data)
        {
            if (!data.IsSuccess)
            {
                return $"ERR ({data.CommandText}): {data.ErrorMessage}";
            }
            return $"OK ({data.CommandText}): {data.RawOutput}";
        }
    }
}
