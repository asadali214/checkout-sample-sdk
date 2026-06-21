using System.Text.Json.Serialization;
using PayPalServerSdk.Models.Enums;

namespace PayPalServerSdk.Models;

/// <summary>
/// The Universal Product Code of the item.
/// </summary>
public record UniversalProductCode
{
    /// <summary>
    /// The Universal Product Code type.
    /// </summary>
    [JsonPropertyName("type")]
    public required UpcType Type { get; init; }

    /// <summary>
    /// The UPC product code of the item.
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; init; }
}
