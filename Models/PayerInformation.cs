using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The payer information.
/// </summary>
public record PayerInformation
{
    /// <summary>
    /// The PayPal` customer account ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_id")]
    public string? AccountId { get; init; }

    /// <summary>
    /// The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// The phone number, in its canonical international <see href="https://www.itu.int/rec/T-REC-E.164/en">E.164 numbering plan format</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public Phone? PhoneNumber { get; init; }

    /// <summary>
    /// The address status of the payer. Value is either: Y. Verified. N. Not verified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address_status")]
    public string? AddressStatus { get; init; }

    /// <summary>
    /// The status of the payer. Value is <c>Y</c> or <c>N</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payer_status")]
    public string? PayerStatus { get; init; }

    /// <summary>
    /// The name of the party.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payer_name")]
    public PayerName? PayerName { get; init; }

    /// <summary>
    /// The <see href="/docs/integration/direct/rest/country-codes/">two-character ISO 3166-1 code</see> that identifies the country or region. Note: The country code for Great Britain is GB and not UK as used in the top-level domain names for that country. Use the <c>C2</c> country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country_code")]
    public string? CountryCode { get; init; }

    /// <summary>
    /// A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public SimplePostalAddressCoarseGrained? Address { get; init; }
}
