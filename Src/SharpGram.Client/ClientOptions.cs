namespace SharpGram.Client;

public sealed class ClientOptions
{
    public bool IsTest { get; set; } = false;
    internal bool IsLocalServer { get; set; } = false;
    public string DeviceModel { get; init; } = "pc";
    public string SystemVersion { get; init; } = "1";
    public string AppVersion { get; init; } = "1";
    public string SystemLangCode { get; init; } = "en";
    public string LangCode { get; init; } = "en";
    public string LangPack { get; init; } = "-";
}