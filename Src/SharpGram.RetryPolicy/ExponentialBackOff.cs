using SharpGram.Client.Models;

namespace SharpGram.RetryPolicy;

public sealed class ExponentialBackOff(TimeSpan initialDelay, TimeSpan maxDelay)
{
    private readonly Random _rnd = new();
    private uint _retryCount;
    /// <summary>
    /// create an exponential backoff to be used for retry polices.
    /// </summary>
    /// <param name="initialDelay">initial delay for the jitter.</param>
    /// <param name="maxDelay">maximum amount of time that is allowed for the client to wait before retrying any call.</param>
    /// <returns></returns>
    public static ExponentialBackOff New(TimeSpan? initialDelay = null, TimeSpan? maxDelay = null)
        => new(initialDelay ?? TimeSpan.FromSeconds(1), maxDelay ?? TimeSpan.FromSeconds(5));
    //IDK what should I call this thing, from, result, response ... don't know
    public RetryPolicyResult Result(bool shouldRetry)
    {
        return RetryPolicyResult.Create(shouldRetry, CalculateDelay());
    }
    internal TimeSpan CalculateDelay()
    {
        _retryCount++;

        var exponentialDelay = TimeSpan.FromMilliseconds(initialDelay.TotalMilliseconds * Math.Pow(2, _retryCount - 1));
        var delay = exponentialDelay + TimeSpan.FromMilliseconds(_rnd.Next((int)exponentialDelay.TotalMilliseconds / 2));

        return delay < maxDelay ? delay : maxDelay;
    }
}