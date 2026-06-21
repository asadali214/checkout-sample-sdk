using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// Information used to pay using BLIK one-click flow.
/// </summary>
public record BlikOneClickPaymentObject
{
    /// <summary>
    /// The merchant generated, unique reference serving as a primary identifier for accounts connected between Blik and a merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consumer_reference")]
    public string? ConsumerReference { get; init; }
}
