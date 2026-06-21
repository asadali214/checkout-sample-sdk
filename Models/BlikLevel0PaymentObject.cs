using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// Information used to pay using BLIK level_0 flow.
/// </summary>
public record BlikLevel0PaymentObject
{
    /// <summary>
    /// The 6-digit code used to authenticate a consumer within BLIK.
    /// </summary>
    [JsonPropertyName("auth_code")]
    public required string AuthCode { get; init; }
}
