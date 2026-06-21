using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// Information needed to pay using Google Pay.
/// </summary>
public record GooglePayRequest
{
    /// <summary>
    /// The full name representation like Mr J Smith.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// The phone number in its canonical international <see href="https://www.itu.int/rec/T-REC-E.164/en">E.164 numbering plan format</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public PhoneNumberWithCountryCode? PhoneNumber { get; init; }

    /// <summary>
    /// The payment card used to fund a Google Pay payment. Can be a credit or debit card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public GooglePayRequestCard? Card { get; init; }

    /// <summary>
    /// Details shared by Google for the merchant to be shared with PayPal. This is required to process the transaction using the Google Pay payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("decrypted_token")]
    public GooglePayDecryptedTokenData? DecryptedToken { get; init; }

    /// <summary>
    /// Information about cardholder possession validation and cardholder identification and verifications (ID&amp;V).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assurance_details")]
    public AssuranceDetails? AssuranceDetails { get; init; }

    /// <summary>
    /// Customizes the payer experience during the approval process for the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("experience_context")]
    public GooglePayExperienceContext? ExperienceContext { get; init; }
}
