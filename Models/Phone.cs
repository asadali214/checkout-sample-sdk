using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The phone number, in its canonical international <see href="https://www.itu.int/rec/T-REC-E.164/en">E.164 numbering plan format</see>.
/// </summary>
public record Phone
{
    /// <summary>
    /// The country calling code (CC), in its canonical international <see href="https://www.itu.int/rec/T-REC-E.164/en">E.164 numbering plan format</see>. The combined length of the CC and the national number must not be greater than 15 digits. The national number consists of a national destination code (NDC) and subscriber number (SN).
    /// </summary>
    [JsonPropertyName("country_code")]
    public required string CountryCode { get; init; }

    /// <summary>
    /// The national number, in its canonical international <see href="https://www.itu.int/rec/T-REC-E.164/en">E.164 numbering plan format</see>. The combined length of the country calling code (CC) and the national number must not be greater than 15 digits. The national number consists of a national destination code (NDC) and subscriber number (SN).
    /// </summary>
    [JsonPropertyName("national_number")]
    public required string NationalNumber { get; init; }

    /// <summary>
    /// The extension number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extension_number")]
    public string? ExtensionNumber { get; init; }
}
