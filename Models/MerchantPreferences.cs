using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The merchant preferences for a subscription.
/// </summary>
public record MerchantPreferences
{
    /// <summary>
    /// The URL where the customer is redirected after the customer approves the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("return_url")]
    public string? ReturnUrl { get; init; }

    /// <summary>
    /// The URL where the customer is redirected after the customer cancels the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancel_url")]
    public string? CancelUrl { get; init; }
}
