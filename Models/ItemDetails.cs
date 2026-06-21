using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The item details.
/// </summary>
public record ItemDetails
{
    /// <summary>
    /// An item code that identifies a merchant's goods or service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_code")]
    public string? ItemCode { get; init; }

    /// <summary>
    /// The item name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_name")]
    public string? ItemName { get; init; }

    /// <summary>
    /// The item description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_description")]
    public string? ItemDescription { get; init; }

    /// <summary>
    /// The item options. Describes option choices on the purchase of the item in some detail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_options")]
    public string? ItemOptions { get; init; }

    /// <summary>
    /// The number of purchased units of goods or a service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_quantity")]
    public string? ItemQuantity { get; init; }

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_unit_price")]
    public Money? ItemUnitPrice { get; init; }

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_amount")]
    public Money? ItemAmount { get; init; }

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discount_amount")]
    public Money? DiscountAmount { get; init; }

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjustment_amount")]
    public Money? AdjustmentAmount { get; init; }

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gift_wrap_amount")]
    public Money? GiftWrapAmount { get; init; }

    /// <summary>
    /// The percentage, as a fixed-point, signed decimal number. For example, define a 19.99% interest rate as <c>19.99</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_percentage")]
    public string? TaxPercentage { get; init; }

    /// <summary>
    /// An array of tax amounts levied by a government on the purchase of goods or services.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_amounts")]
    public IReadOnlyList<TaxAmount>? TaxAmounts { get; init; }

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("basic_shipping_amount")]
    public Money? BasicShippingAmount { get; init; }

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extra_shipping_amount")]
    public Money? ExtraShippingAmount { get; init; }

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("handling_amount")]
    public Money? HandlingAmount { get; init; }

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("insurance_amount")]
    public Money? InsuranceAmount { get; init; }

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_item_amount")]
    public Money? TotalItemAmount { get; init; }

    /// <summary>
    /// The invoice number. An alphanumeric string that identifies a billing for a merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoice_number")]
    public string? InvoiceNumber { get; init; }

    /// <summary>
    /// An array of checkout options. Each option has a name and value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkout_options")]
    public IReadOnlyList<CheckoutOption>? CheckoutOptions { get; init; }
}
