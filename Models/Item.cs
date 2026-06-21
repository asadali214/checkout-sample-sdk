using System.Text.Json.Serialization;
using PayPalServerSdk.Models.Enums;

namespace PayPalServerSdk.Models;

/// <summary>
/// The details for the items to be purchased.
/// </summary>
public record Item
{
    /// <summary>
    /// The item name or title.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonPropertyName("unit_amount")]
    public required Money UnitAmount { get; init; }

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax")]
    public Money? Tax { get; init; }

    /// <summary>
    /// The item quantity. Must be a whole number.
    /// </summary>
    [JsonPropertyName("quantity")]
    public required string Quantity { get; init; }

    /// <summary>
    /// The detailed item description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The stock keeping unit (SKU) for the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sku")]
    public string? Sku { get; init; }

    /// <summary>
    /// The URL to the item being purchased. Visible to buyer and used in buyer experiences.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }

    /// <summary>
    /// The item category type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    public ItemCategory? Category { get; init; }

    /// <summary>
    /// The URL of the item's image. File type and size restrictions apply. An image that violates these restrictions will not be honored.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image_url")]
    public string? ImageUrl { get; init; }

    /// <summary>
    /// The Universal Product Code of the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("upc")]
    public UniversalProductCode? Upc { get; init; }

    /// <summary>
    /// Metadata for merchant-managed recurring billing plans. Valid only during the saved payment method token or billing agreement creation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billing_plan")]
    public OrderBillingPlan? BillingPlan { get; init; }
}
