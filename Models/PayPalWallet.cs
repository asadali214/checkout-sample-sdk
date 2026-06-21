using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// A resource that identifies a PayPal Wallet is used for payment.
/// </summary>
public record PayPalWallet
{
    /// <summary>
    /// The PayPal-generated ID for the vaulted payment source. This ID should be stored on the merchant's server so the saved payment source can be used for future transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vault_id")]
    public string? VaultId { get; init; }

    /// <summary>
    /// The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// The name of the party.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public Name? Name { get; init; }

    /// <summary>
    /// The phone information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public PhoneWithType? Phone { get; init; }

    /// <summary>
    /// The stand-alone date, in <see href="https://tools.ietf.org/html/rfc3339#section-5.6">Internet date and time format</see>. To represent special legal values, such as a date of birth, you should use dates with no associated time or time-zone data. Whenever possible, use the standard <c>date_time</c> type. This regular expression does not validate all dates. For example, February 31 is valid and nothing is known about leap years.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("birth_date")]
    public string? BirthDate { get; init; }

    /// <summary>
    /// The tax ID of the customer. The customer is also known as the payer. Both <c>tax_id</c> and <c>tax_id_type</c> are required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_info")]
    public TaxInfo? TaxInfo { get; init; }

    /// <summary>
    /// The portable international postal address. Maps to <see href="https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata">AddressValidationMetadata</see> and HTML 5.1 <see href="https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute">Autofilling form controls: the autocomplete attribute</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public Address? Address { get; init; }

    /// <summary>
    /// Additional attributes associated with the use of this PayPal Wallet.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attributes")]
    public PayPalWalletAttributes? Attributes { get; init; }

    /// <summary>
    /// Customizes the payer experience during the approval process for payment with PayPal. Note: Partners and Marketplaces might configure brand_name and shipping_preference during partner account setup, which overrides the request values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("experience_context")]
    public PayPalWalletExperienceContext? ExperienceContext { get; init; }

    /// <summary>
    /// The PayPal billing agreement ID. References an approved recurring payment for goods or services.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billing_agreement_id")]
    public string? BillingAgreementId { get; init; }

    /// <summary>
    /// Provides additional details to process a payment using the PayPal wallet billing agreement or a vaulted payment method that has been stored or is intended to be stored.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stored_credential")]
    public PayPalWalletStoredCredential? StoredCredential { get; init; }
}
