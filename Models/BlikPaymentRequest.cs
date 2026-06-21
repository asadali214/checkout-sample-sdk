using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// Information needed to pay using BLIK.
/// </summary>
public record BlikPaymentRequest
{
    /// <summary>
    /// The full name representation like Mr J Smith.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The <see href="/api/rest/reference/country-codes/">two-character ISO 3166-1 code</see> that identifies the country or region. Note: The country code for Great Britain is GB and not UK as used in the top-level domain names for that country. Use the <c>C2</c> country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.
    /// </summary>
    [JsonPropertyName("country_code")]
    public required string CountryCode { get; init; }

    /// <summary>
    /// The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    /// <summary>
    /// Customizes the payer experience during the approval process for the BLIK payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("experience_context")]
    public BlikExperienceContext? ExperienceContext { get; init; }

    /// <summary>
    /// Information used to pay using BLIK level_0 flow.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("level_0")]
    public BlikLevel0PaymentObject? Level0 { get; init; }

    /// <summary>
    /// Information used to pay using BLIK one-click flow.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("one_click")]
    public BlikOneClickPaymentRequest? OneClick { get; init; }
}
