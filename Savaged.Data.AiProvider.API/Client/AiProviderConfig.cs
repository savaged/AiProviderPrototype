namespace Savaged.Data.AiProvider.API.Client;

public static partial class AiProviderConfig
{
    // Set in partial
    private static string _apiKey = "";

    public static string GetApiKey() => _apiKey;
}
