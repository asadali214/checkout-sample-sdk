using System.Collections.Generic;
using System.Text.Json.Serialization;
using PayPalServerSdk.Models.Enums;

namespace PayPalServerSdk.Models;

/// <summary>
/// The shipping details.
/// </summary>
public record ShippingDetails
{
    /// <summary>
    /// The name of the party.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public ShippingName? Name { get; init; }

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
    /// A classification for the method of purchase fulfillment (e.g shipping, in-store pickup, etc). Either <c>type</c> or <c>options</c> may be present, but not both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public FulfillmentType? Type { get; init; }

    /// <summary>
    /// An array of shipping options that the payee or merchant offers to the payer to ship or pick up their items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public IReadOnlyList<ShippingOption>? Options { get; init; }

    /// <summary>
    /// The portable international postal address. Maps to <see href="https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata">AddressValidationMetadata</see> and HTML 5.1 <see href="https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute">Autofilling form controls: the autocomplete attribute</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public Address? Address { get; init; }
}
