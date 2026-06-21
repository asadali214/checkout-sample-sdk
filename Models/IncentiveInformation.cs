using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The incentive details.
/// </summary>
public record IncentiveInformation
{
    /// <summary>
    /// An array of incentive details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("incentive_details")]
    public IReadOnlyList<IncentiveDetails>? IncentiveDetails { get; init; }
}
