using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// Metadata for merchant-managed recurring billing plans. Valid only during the saved payment method token or billing agreement creation.
/// </summary>
public record OrderBillingPlan
{
    /// <summary>
    /// An array of billing cycles for trial billing and regular billing. A plan can have at most two trial cycles and only one regular cycle.
    /// </summary>
    [JsonPropertyName("billing_cycles")]
    public required IReadOnlyList<BillingCycle> BillingCycles { get; init; }

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("setup_fee")]
    public Money? SetupFee { get; init; }

    /// <summary>
    /// Name of the recurring plan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
