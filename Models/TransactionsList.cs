using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The list transactions for a subscription request details.
/// </summary>
public record TransactionsList
{
    /// <summary>
    /// An array of transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactions")]
    public IReadOnlyList<SubscriptionTransactionDetails>? Transactions { get; init; }

    /// <summary>
    /// The total number of items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_items")]
    public double? TotalItems { get; init; }

    /// <summary>
    /// The total number of pages.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_pages")]
    public double? TotalPages { get; init; }

    /// <summary>
    /// An array of request-related <see href="/docs/api/reference/api-responses/#hateoas-links">HATEOAS links</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("links")]
    public IReadOnlyList<LinkDescription>? Links { get; init; }
}
