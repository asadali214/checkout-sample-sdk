using System.Text.Json.Serialization;
using PayPalServerSdk.Models.Enums;

namespace PayPalServerSdk.Models;

/// <summary>
/// Full representation of a Venmo Payment Token.
/// </summary>
public record VenmoPaymentToken
{
    /// <summary>
    /// The description displayed to the consumer on the approval flow for a digital wallet, as well as on the merchant view of the payment token management experience. exp: PayPal.com.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Expected business/charge model for the billing agreement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usage_pattern")]
    public UsagePattern? UsagePattern { get; init; }

    /// <summary>
    /// The shipping details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipping")]
    public VaultedDigitalWalletShippingDetails? Shipping { get; init; }

    /// <summary>
    /// Create multiple payment tokens for the same payer, merchant/platform combination. Use this when the customer has not logged in at merchant/platform. The payment token thus generated, can then also be used to create the customer account at merchant/platform. Use this also when multiple payment tokens are required for the same payer, different customer at merchant/platform. This helps to identify customers distinctly even though they may share the same PayPal account. This only applies to PayPal payment source.
    /// </summary>
    [JsonPropertyName("permit_multiple_payment_tokens")]
    public bool? PermitMultiplePaymentTokens { get; init; } = false;

    /// <summary>
    /// The usage type associated with a digital wallet payment token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usage_type")]
    public PayPalPaymentTokenUsageType? UsageType { get; init; }

    /// <summary>
    /// The customer type associated with a digital wallet payment token. This is to indicate whether the customer acting on the merchant / platform is either a business or a consumer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_type")]
    public PayPalPaymentTokenCustomerType? CustomerType { get; init; }

    /// <summary>
    /// The internationalized email address.&lt;blockquote&gt;&lt;strong&gt;Note:&lt;/strong&gt; Up to 64 characters are allowed before and 255 characters are allowed after the &lt;code&gt;@&lt;/code&gt; sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted &lt;code&gt;@&lt;/code&gt; sign exists.&lt;/blockquote&gt;
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// The account identifier for a PayPal account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payer_id")]
    public string? PayerId { get; init; }

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
    /// The portable international postal address. Maps to <see href="https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata">AddressValidationMetadata</see> and HTML 5.1 <see href="https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute">Autofilling form controls: the autocomplete attribute</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public Address? Address { get; init; }

    /// <summary>
    /// The Venmo username, as chosen by the user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_name")]
    public string? UserName { get; init; }
}
