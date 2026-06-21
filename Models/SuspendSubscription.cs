using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The suspend subscription request details.
/// </summary>
public record SuspendSubscription
{
    /// <summary>
    /// The reason for suspension of the Subscription.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; init; }
}
