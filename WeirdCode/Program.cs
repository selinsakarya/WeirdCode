// See https://aka.ms/new-console-template for more information

using WeirdCode;

// await AwaitAnything();

// EnumeratorMagic();

// DateTimeExtension();

// Lock();

// CrazyAsync();

async Task AwaitAnything()
{
    Console.WriteLine(TimeProvider.System.GetUtcNow());

    await 2;

    Console.WriteLine(TimeProvider.System.GetUtcNow());
}

void EnumeratorMagic()
{
    foreach (int i in 5)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("---");

    foreach (int i in 10..15)
    {
        Console.WriteLine(i);
    }
}

void DateTimeExtension()
{
    DateTime today = 4.January(2024);

    Console.WriteLine(today);
}

void Lock()
{
    object o = new object();

    lock (o)
    {
        Console.WriteLine("This was locked and thread safe");
    }
}

void CrazyAsync()
{
    async async async (async async) => await async[async][async][async][async];

    Console.WriteLine("Hello world");
}

