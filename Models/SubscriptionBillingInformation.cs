using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The billing details for the subscription. If the subscription was or is active, these fields are populated.
/// </summary>
public record SubscriptionBillingInformation
{
    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonPropertyName("outstanding_balance")]
    public required Money OutstandingBalance { get; init; }

    /// <summary>
    /// The trial and regular billing executions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cycle_executions")]
    public IReadOnlyList<CycleExecution>? CycleExecutions { get; init; }

    /// <summary>
    /// The details for the last payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_payment")]
    public LastPaymentDetails? LastPayment { get; init; }

    /// <summary>
    /// The date and time, in <see href="https://tools.ietf.org/html/rfc3339#section-5.6">Internet date and time format</see>. Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next_billing_time")]
    public string? NextBillingTime { get; init; }

    /// <summary>
    /// The date and time, in <see href="https://tools.ietf.org/html/rfc3339#section-5.6">Internet date and time format</see>. Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("final_payment_time")]
    public string? FinalPaymentTime { get; init; }

    /// <summary>
    /// The number of consecutive payment failures. Resets to <c>0</c> after a successful payment. If this reaches the <c>payment_failure_threshold</c> value, the subscription updates to the <c>SUSPENDED</c> state.
    /// </summary>
    [JsonPropertyName("failed_payments_count")]
    public required double FailedPaymentsCount { get; init; }

    /// <summary>
    /// The details for the failed payment of the subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_failed_payment")]
    public FailedPaymentDetails? LastFailedPayment { get; init; }
}
