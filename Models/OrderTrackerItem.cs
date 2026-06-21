using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The details of the items in the shipment.
/// </summary>
public record OrderTrackerItem
{
    /// <summary>
    /// The item name or title.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The item quantity. Must be a whole number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity")]
    public string? Quantity { get; init; }

    /// <summary>
    /// The stock keeping unit (SKU) for the item. This can contain unicode characters.
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
}
