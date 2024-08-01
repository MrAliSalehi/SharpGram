using OneOf;
using OneOf.Types;
using SharpGram.Client.Contracts;

namespace SharpGram.Client.Models;

public struct RetryPolicyResult
{
    internal bool ShouldRetry = false;
    internal TimeSpan Delay = TimeSpan.Zero;
    private RetryPolicyResult(bool shouldRetry, TimeSpan delay)
    {
        ShouldRetry = shouldRetry;
        Delay = delay;
    }
    public static RetryPolicyResult Create(bool shouldRetry, TimeSpan delay = default) => new(shouldRetry, delay);


    public static implicit operator RetryPolicyResult((bool, TimeSpan) t) => new(t.Item1, t.Item2);
    public static implicit operator ValueTask<RetryPolicyResult>(RetryPolicyResult self) => ValueTask.FromResult(self);
}


