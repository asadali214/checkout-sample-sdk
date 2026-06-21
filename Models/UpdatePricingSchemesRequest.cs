using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The update pricing scheme request details.
/// </summary>
public record UpdatePricingSchemesRequest
{
    /// <summary>
    /// An array of pricing schemes.
    /// </summary>
    [JsonPropertyName("pricing_schemes")]
    public required IReadOnlyList<UpdatePricingScheme> PricingSchemes { get; init; }
}
