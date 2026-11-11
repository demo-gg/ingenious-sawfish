using System;
using System.Text.Json.Serialization;

public class ChatMessage
{
    [JsonPropertyName("role")]
    public string Role { get; set; }

    [JsonPropertyName("content")]
    public string Content { get; set; }

    public ChatMessage() { }

    public ChatMessage(string role, string content)
    {
        Role = role ?? throw new ArgumentNullException(nameof(role));
        Content = content ?? throw new ArgumentNullException(nameof(content));
    }

    public override string ToString() => $"[{Role}] {Content}";
}
