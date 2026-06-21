using System.Collections.Generic;
using System.Text.Json.Serialization;
using PayPalServerSdk.Models.Enums;

namespace PayPalServerSdk.Models;

/// <summary>
/// Minimal representation of a cached setup token.
/// </summary>
public record SetupTokenResponse
{
    /// <summary>
    /// The PayPal-generated ID for the vaulted payment source. This ID should be stored on the merchant's server so the saved payment source can be used for future transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// This object defines a customer in your system. Use it to manage customer profiles, save payment methods and contact details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer")]
    public Customer? Customer { get; init; }

    /// <summary>
    /// The status of the payment token.
    /// </summary>
    [JsonPropertyName("status")]
    public PaymentTokenStatus? Status { get; init; } = PaymentTokenStatus.Created;

    /// <summary>
    /// The setup payment method details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_source")]
    public SetupTokenResponsePaymentSource? PaymentSource { get; init; }

    /// <summary>
    /// An array of related <see href="/api/rest/responses/#hateoas">HATEOAS links</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("links")]
    public IReadOnlyList<LinkDescription>? Links { get; init; }
}
