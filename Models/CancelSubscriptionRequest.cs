using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The cancel subscription request details.
/// </summary>
public record CancelSubscriptionRequest
{
    /// <summary>
    /// The reason for the cancellation of a subscription.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; init; }
}
