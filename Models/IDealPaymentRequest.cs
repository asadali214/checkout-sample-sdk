using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// Information needed to pay using iDEAL.
/// </summary>
public record IDealPaymentRequest
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
    /// The business identification code (BIC). In payments systems, a BIC is used to identify a specific business, most commonly a bank.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bic")]
    public string? Bic { get; init; }

    /// <summary>
    /// Customizes the payer experience during the approval process for the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("experience_context")]
    public ExperienceContext? ExperienceContext { get; init; }
}
