using System.Text.Json.Serialization;
using PayPalServerSdk.Models.Enums;

namespace PayPalServerSdk.Models;

/// <summary>
/// The transaction details.
/// </summary>
public record SubscriptionTransactionDetails
{
    /// <summary>
    /// The status of the captured payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public CaptureStatus? Status { get; init; }

    /// <summary>
    /// The PayPal-generated transaction ID.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The breakdown details for the amount. Includes the gross, tax, fee, and shipping amounts.
    /// </summary>
    [JsonPropertyName("amount_with_breakdown")]
    public required SubscriptionAmountWithBreakdown AmountWithBreakdown { get; init; }

    /// <summary>
    /// The name of the party.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payer_name")]
    public SubscriptionPayerName? PayerName { get; init; }

    /// <summary>
    /// The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payer_email")]
    public string? PayerEmail { get; init; }

    /// <summary>
    /// The date and time, in <see href="https://tools.ietf.org/html/rfc3339#section-5.6">Internet date and time format</see>. Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.
    /// </summary>
    [JsonPropertyName("time")]
    public required string Time { get; init; }
}
