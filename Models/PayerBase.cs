using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The customer who approves and pays for the order. The customer is also known as the payer.
/// </summary>
public record PayerBase
{
    /// <summary>
    /// The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// The account identifier for a PayPal account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payer_id")]
    public string? PayerId { get; init; }
}
