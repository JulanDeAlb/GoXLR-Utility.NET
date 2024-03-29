using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace GoXLR_Utility.NET.Tests;

public class XUnitLogger : ILogger
{
    private readonly ITestOutputHelper _output;

    public XUnitLogger(ITestOutputHelper output)
    {
        _output = output;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        _output.WriteLine(exception != null ? $"Message: {state} | Exception: {exception}" : $"Message: {state}");
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        return false;
    }

    public IDisposable BeginScope<TState>(TState state) where TState : notnull
    {
        return null!;
    }
}