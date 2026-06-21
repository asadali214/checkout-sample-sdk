using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// Information needed to pay using ApplePay.
/// </summary>
public record ApplePayPaymentObject
{
    /// <summary>
    /// ApplePay transaction identifier, this will be the unique identifier for this transaction provided by Apple. The pattern is defined by an external party and supports Unicode.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Encrypted ApplePay token, containing card information. This token would be base64encoded. The pattern is defined by an external party and supports Unicode.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token")]
    public string? Token { get; init; }

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
    public PhoneNumber? PhoneNumber { get; init; }

    /// <summary>
    /// The Card from Apple Pay Wallet used to fund the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public ApplePayCardResponse? Card { get; init; }

    /// <summary>
    /// Additional attributes associated with the use of Apple Pay.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attributes")]
    public ApplePayAttributesResponse? Attributes { get; init; }

    /// <summary>
    /// Provides additional details to process a payment using a <c>card</c> that has been stored or is intended to be stored (also referred to as stored_credential or card-on-file). Parameter compatibility: <c>payment_type=ONE_TIME</c> is compatible only with <c>payment_initiator=CUSTOMER</c>. <c>usage=FIRST</c> is compatible only with <c>payment_initiator=CUSTOMER</c>. <c>previous_transaction_reference</c> or <c>previous_network_transaction_reference</c> is compatible only with <c>payment_initiator=MERCHANT</c>. Only one of the parameters - <c>previous_transaction_reference</c> and <c>previous_network_transaction_reference</c> - can be present in the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stored_credential")]
    public CardStoredCredential? StoredCredential { get; init; }
}
