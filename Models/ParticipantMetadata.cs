using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// Profile information of the sender or receiver.
/// </summary>
public record ParticipantMetadata
{
    /// <summary>
    /// An Internet Protocol address (IP address). This address assigns a numerical label to each device that is connected to a computer network through the Internet Protocol. Supports IPv4 and IPv6 addresses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ip_address")]
    public string? IpAddress { get; init; }
}
