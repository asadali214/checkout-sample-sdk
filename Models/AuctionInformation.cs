using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The auction information.
/// </summary>
public record AuctionInformation
{
    /// <summary>
    /// The name of the auction site.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auction_site")]
    public string? AuctionSite { get; init; }

    /// <summary>
    /// The auction site URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auction_item_site")]
    public string? AuctionItemSite { get; init; }

    /// <summary>
    /// The ID of the buyer who makes the purchase in the auction. This ID might be different from the payer ID provided for the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auction_buyer_id")]
    public string? AuctionBuyerId { get; init; }

    /// <summary>
    /// The date and time, in <see href="https://tools.ietf.org/html/rfc3339#section-5.6">Internet date and time format</see>. Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auction_closing_date")]
    public string? AuctionClosingDate { get; init; }
}
