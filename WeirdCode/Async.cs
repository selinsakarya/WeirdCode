using System.Runtime.CompilerServices;

namespace WeirdCode;

[AsyncMethodBuilder(typeof(builder))]
class async {
    public async this[async async] { get => null; }
}

static class until { 
    public static awaiter GetAwaiter(this async a) => throw null;
}

class awaiter : INotifyCompletion {
    public bool IsCompleted => true;
    public void GetResult() { }
    public void OnCompleted(Action continuation) { }
}

class builder
{
    public builder() { }
    public static builder Create() => throw null;
    public void SetResult() { }
    public void SetException(Exception e) { }
    public void Start<TStateMachine>(ref TStateMachine stateMachine)
        where TStateMachine : IAsyncStateMachine => throw null;
    public async Task => throw null;
    public void AwaitOnCompleted<TAwaiter, TStateMachine>(
        ref TAwaiter awaiter, ref TStateMachine stateMachine)
        where TAwaiter : INotifyCompletion
        where TStateMachine : IAsyncStateMachine => throw null;
    public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(
        ref TAwaiter awaiter, ref TStateMachine stateMachine)
        where TAwaiter : ICriticalNotifyCompletion
        where TStateMachine : IAsyncStateMachine => throw null;
    public void SetStateMachine(IAsyncStateMachine stateMachine) => throw null;
}