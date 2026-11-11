using System;

public class ClientConfig
{
    public string ApiKey { get; set; }
    public string BaseUrl { get; set; } = "https://api.openai.com/v1";
    public string Model { get; set; } = "gpt-4";
    public int TimeoutSeconds { get; set; } = 30;
    public double Temperature { get; set; } = 0.7;

    public ClientConfig(string apiKey)
    {
        if (string.IsNullOrWhiteSpace(apiKey))
            throw new ArgumentException("API key cannot be empty", nameof(apiKey));
        ApiKey = apiKey;
    }

    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(ApiKey))
            throw new InvalidOperationException("API key is required for initialization");
    }
}
