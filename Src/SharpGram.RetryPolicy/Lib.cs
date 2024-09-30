using SharpGram.Client;
using SharpGram.Client.Contracts;
using SharpGram.Client.Models;
using SharpGram.Core.Contracts;

namespace SharpGram.RetryPolicy;

/// <summary>
/// enables a fixed number of retries for the client.
/// </summary>
public sealed class FixedRetry : IRetryPolicy
{
    private readonly uint _maxRetries;
    private readonly ExponentialBackOff? _eb;
    private readonly TimeSpan? _staticDelay;
    /// <summary>
    /// enables a fixed number of retries for the client.
    /// either exponential backoff or the constant delay will be used and NOT both of them.
    /// </summary>
    /// <param name="maxRetries">how many retries can the library do before returning an error.</param>
    /// <param name="eb">Optional, Exponential Backoff delay can be used to introduce random delays between each retry</param>
    /// <param name="staticDelay">Optional, a constant delay to be applied before each retry</param>
    public FixedRetry(uint maxRetries, ExponentialBackOff? eb = null, TimeSpan? staticDelay = default)
    {
        _maxRetries = maxRetries;
        _eb = eb;
        _staticDelay = staticDelay;
    }
    public ValueTask<RetryPolicyResult> ShouldRetryAsync<T>(TelegramClient client, TlFunction<T> request, uint retryCounts) where T : ITlDeserializable<T>
    {
        var should = retryCounts <= _maxRetries;
        return _eb?.Result(should) ?? RetryPolicyResult.Create(should, _staticDelay ?? default);
    }
}

/// <summary>
/// disable retrying.
/// </summary>
public sealed class NoRetry : IRetryPolicy
{
    public ValueTask<RetryPolicyResult> ShouldRetryAsync<T>(TelegramClient client, TlFunction<T> request, uint retryCounts) where T : ITlDeserializable<T>
        => RetryPolicyResult.Create(false);
}

public sealed class DelayedRetry : IRetryPolicy
{
    private readonly ExponentialBackOff? _eb;
    private readonly TimeSpan? _staticDelay;
    /// <summary>
    /// enables a delayed retry policy without any retry count limits.
    /// either exponential backoff or the constant delay will be used and NOT both of them.
    /// </summary>
    /// <param name="eb">Optional, Exponential Backoff delay can be used to introduce random delays between each retry</param>
    /// <param name="staticDelay">Optional, a constant delay to be applied before each retry</param>
    public DelayedRetry(ExponentialBackOff? eb = null, TimeSpan? staticDelay = default)
    {
        _eb = eb;
        _staticDelay = staticDelay;
    }
    public ValueTask<RetryPolicyResult> ShouldRetryAsync<T>(TelegramClient client, TlFunction<T> request, uint retryCounts) where T : ITlDeserializable<T>
    {
        return _eb?.Result(true) ?? RetryPolicyResult.Create(true, _staticDelay ?? default);
    }
}