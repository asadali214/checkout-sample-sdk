using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The plan details.
/// </summary>
public record PlanDetails
{
    /// <summary>
    /// The ID for the product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("product_id")]
    public string? ProductId { get; init; }

    /// <summary>
    /// The plan name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The detailed description of the plan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// An array of billing cycles for trial billing and regular billing. A plan can have at most two trial cycles and only one regular cycle.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billing_cycles")]
    public IReadOnlyList<SubscriptionBillingCycle>? BillingCycles { get; init; }

    /// <summary>
    /// The payment preferences for a subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_preferences")]
    public PaymentPreferences? PaymentPreferences { get; init; }

    /// <summary>
    /// The merchant preferences for a subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_preferences")]
    public MerchantPreferences? MerchantPreferences { get; init; }

    /// <summary>
    /// The tax details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxes")]
    public Taxes? Taxes { get; init; }

    /// <summary>
    /// Indicates whether you can subscribe to this plan by providing a quantity for the goods or service.
    /// </summary>
    [JsonPropertyName("quantity_supported")]
    public bool? QuantitySupported { get; init; } = false;
}
