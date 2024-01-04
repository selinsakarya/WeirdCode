using System.Runtime.CompilerServices;

namespace WeirdCode;

public static class AwaitAnything
{
    public static TaskAwaiter GetAwaiter(this int seconds)
    {
        return Task.Delay(TimeSpan.FromSeconds(seconds)).GetAwaiter();
    }
}