using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The update pricing scheme request details.
/// </summary>
public record UpdatePricingScheme
{
    /// <summary>
    /// The billing cycle sequence.
    /// </summary>
    [JsonPropertyName("billing_cycle_sequence")]
    public required double BillingCycleSequence { get; init; }

    /// <summary>
    /// The pricing scheme details.
    /// </summary>
    [JsonPropertyName("pricing_scheme")]
    public required SubscriptionPricingScheme PricingScheme { get; init; }
}
