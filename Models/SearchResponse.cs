using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The search response information.
/// </summary>
public record SearchResponse
{
    /// <summary>
    /// An array of transaction detail objects.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_details")]
    public IReadOnlyList<TransactionDetails>? TransactionDetails { get; init; }

    /// <summary>
    /// The merchant account number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_number")]
    public string? AccountNumber { get; init; }

    /// <summary>
    /// The date and time, in <see href="https://tools.ietf.org/html/rfc3339#section-5.6">Internet date and time format</see>. Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_date")]
    public string? StartDate { get; init; }

    /// <summary>
    /// The date and time, in <see href="https://tools.ietf.org/html/rfc3339#section-5.6">Internet date and time format</see>. Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_date")]
    public string? EndDate { get; init; }

    /// <summary>
    /// The date and time, in <see href="https://tools.ietf.org/html/rfc3339#section-5.6">Internet date and time format</see>. Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_refreshed_datetime")]
    public string? LastRefreshedDatetime { get; init; }

    /// <summary>
    /// A zero-relative index of transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("page")]
    public double? Page { get; init; }

    /// <summary>
    /// The total number of transactions as an integer beginning with the specified <c>page</c> in the full result and not just in this response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_items")]
    public double? TotalItems { get; init; }

    /// <summary>
    /// The total number of pages, as an <c>integer</c>, when the <c>total_items</c> is divided into pages of the specified <c>page_size</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_pages")]
    public double? TotalPages { get; init; }

    /// <summary>
    /// An array of request-related <see href="/api/rest/responses/#hateoas-links">HATEOAS links</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("links")]
    public IReadOnlyList<LinkDescription>? Links { get; init; }
}
