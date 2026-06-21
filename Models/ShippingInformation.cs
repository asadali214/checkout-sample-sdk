using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The shipping information.
/// </summary>
public record ShippingInformation
{
    /// <summary>
    /// The recipient's name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The shipping method that is associated with this order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("method")]
    public string? Method { get; init; }

    /// <summary>
    /// A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public SimplePostalAddressCoarseGrained? Address { get; init; }

    /// <summary>
    /// A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondary_shipping_address")]
    public SimplePostalAddressCoarseGrained? SecondaryShippingAddress { get; init; }
}
