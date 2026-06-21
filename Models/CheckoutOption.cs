using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// A checkout option as a name-and-value pair.
/// </summary>
public record CheckoutOption
{
    /// <summary>
    /// The checkout option name, such as <c>color</c> or <c>texture</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkout_option_name")]
    public string? CheckoutOptionName { get; init; }

    /// <summary>
    /// The checkout option value. For example, the checkout option <c>color</c> might be <c>blue</c> or <c>red</c> while the checkout option <c>texture</c> might be <c>smooth</c> or <c>rippled</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkout_option_value")]
    public string? CheckoutOptionValue { get; init; }
}
