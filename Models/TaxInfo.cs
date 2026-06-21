using System.Text.Json.Serialization;
using PayPalServerSdk.Models.Enums;

namespace PayPalServerSdk.Models;

/// <summary>
/// The tax ID of the customer. The customer is also known as the payer. Both <c>tax_id</c> and <c>tax_id_type</c> are required.
/// </summary>
public record TaxInfo
{
    /// <summary>
    /// The customer's tax ID value.
    /// </summary>
    [JsonPropertyName("tax_id")]
    public required string TaxId { get; init; }

    /// <summary>
    /// The customer's tax ID type.
    /// </summary>
    [JsonPropertyName("tax_id_type")]
    public required TaxIdType TaxIdType { get; init; }
}
