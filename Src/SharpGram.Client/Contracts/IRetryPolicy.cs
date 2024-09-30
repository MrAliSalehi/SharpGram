using SharpGram.Client.Models;
using SharpGram.Core.Contracts;

namespace SharpGram.Client.Contracts;

public interface IRetryPolicy
{
     /// <summary>
     /// function to determine whether the request should be retried or not
     /// </summary>
     /// <param name="client"></param>
     /// <param name="request">the request that was trying to be invoked</param>
     /// <param name="retryCounts">number of attempts that has been done</param>
     /// <typeparam name="T"></typeparam>
     /// <returns></returns>
     ValueTask<RetryPolicyResult> ShouldRetryAsync<T>(TelegramClient client, TlFunction<T> request, uint retryCounts) where T : ITlDeserializable<T>;
}
