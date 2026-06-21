using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// Information about the decrypted apple pay payment data for the token like cryptogram, eci indicator.
/// </summary>
public record ApplePayPaymentData
{
    /// <summary>
    /// Online payment cryptogram, as defined by 3D Secure. The pattern is defined by an external party and supports Unicode.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cryptogram")]
    public string? Cryptogram { get; init; }

    /// <summary>
    /// ECI indicator, as defined by 3- Secure. The pattern is defined by an external party and supports Unicode.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eci_indicator")]
    public string? EciIndicator { get; init; }

    /// <summary>
    /// Encoded Apple Pay EMV Payment Structure used for payments in China. The pattern is defined by an external party and supports Unicode.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emv_data")]
    public string? EmvData { get; init; }

    /// <summary>
    /// Bank Key encrypted Apple Pay PIN. The pattern is defined by an external party and supports Unicode.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pin")]
    public string? Pin { get; init; }
}
