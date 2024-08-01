using SharpGram.Client.Models;
using SharpGram.Core.Contracts;

namespace SharpGram.Client.Contracts;

public interface IRetryPolicy
{
     ValueTask<RetryPolicyResult> ShouldRetryAsync<T>(TelegramClient client, TlFunction<T> request, uint retryCounts) where T : ITlDeserializable<T>;
}
