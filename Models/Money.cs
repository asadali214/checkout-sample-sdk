using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The currency and amount for a financial transaction, such as a balance or payment due.
/// </summary>
public record Money
{
    /// <summary>
    /// The <see href="/api/rest/reference/currency-codes/">three-character ISO-4217 currency code</see> that identifies the currency.
    /// </summary>
    [JsonPropertyName("currency_code")]
    public required string CurrencyCode { get; init; }

    /// <summary>
    /// The value, which might be: An integer for currencies like <c>JPY</c> that are not typically fractional. A decimal fraction for currencies like <c>TND</c> that are subdivided into thousandths. For the required number of decimal places for a currency code, see <see href="/api/rest/reference/currency-codes/">Currency Codes</see>.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; init; }
}
