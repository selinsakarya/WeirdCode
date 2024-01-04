namespace System.Threading;
// namespace Asd;

public class Monitor
{
    public static void Enter(object o, ref bool lockTaken)
    {
        Console.WriteLine("Entering lock");
        
        lockTaken = true;
    }
    
    public static void Exit(object o)
    {
        Console.WriteLine("Exiting lock");
    }
}

