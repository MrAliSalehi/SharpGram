using SharpGram.Tl.Constructors.UserNs;

namespace SharpGram.Client.Models;

public sealed class CompactUser
{
    public string Phone { get; set; } = default!;
    public string? Username { get; set; }
    public long Id { get; set; }
    public string Firstname { get; set; } = default!;

    public static implicit operator CompactUser(User u) => new()
    {
        Firstname = u.FirstName ?? "",
        Id = u.Id,
        Phone = u.Phone ?? "",
        Username = u.Username
    };
}