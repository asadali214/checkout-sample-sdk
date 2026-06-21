using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// Collection of payment tokens saved for a given customer.
/// </summary>
public record CustomerVaultPaymentTokensResponse
{
    /// <summary>
    /// Total number of items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_items")]
    public double? TotalItems { get; init; }

    /// <summary>
    /// Total number of pages.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_pages")]
    public double? TotalPages { get; init; }

    /// <summary>
    /// This object defines a customer in your system. Use it to manage customer profiles, save payment methods and contact details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer")]
    public VaultResponseCustomer? Customer { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_tokens")]
    public IReadOnlyList<PaymentTokenResponse>? PaymentTokens { get; init; }

    /// <summary>
    /// An array of related <see href="/api/rest/responses/#hateoas">HATEOAS links</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("links")]
    public IReadOnlyList<LinkDescription>? Links { get; init; }
}
