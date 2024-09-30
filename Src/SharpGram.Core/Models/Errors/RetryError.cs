using NetEscapades.EnumGenerators;
using OneOf;
using SharpGram.Core.Contracts;

namespace SharpGram.Core.Models.Errors;

public class RetryError : ErrorBase
{
    public RetryErrType RetryErr { get; private init; }
    public override string ToString() => RetryErr.ToStringFast();
    public static RetryError Retry() => new() { RetryErr = RetryErrType.Retry };
    public static RetryError RetryMigrate() => new() { RetryErr = RetryErrType.MigrationRetry };
}

[EnumExtensions]
public enum RetryErrType
{
    Retry,
    MigrationRetry
}