using System.Text.Json.Serialization;
using PayPalServerSdk.Models.Enums;

namespace PayPalServerSdk.Models;

/// <summary>
/// Card Verification details including the authorization details and 3D SECURE details.
/// </summary>
public record CardVerificationDetails
{
    /// <summary>
    /// DEPRECATED. This field is DEPRECATED. Please find the network transaction id data in the 'id' field under the 'network_transaction_reference' object instead of the 'verification' object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("network_transaction_id")]
    public string? NetworkTransactionId { get; init; }

    /// <summary>
    /// DEPRECATED. This field is DEPRECATED. Please find the date data in the 'date' field under the 'network_transaction_reference' object instead of the 'verification' object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date")]
    public string? Date { get; init; }

    /// <summary>
    /// DEPRECATED. This field is DEPRECATED. Please find the network data in the 'network' field under the 'network_transaction_reference' object instead of the 'verification' object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("network")]
    public CardBrand? Network { get; init; }

    /// <summary>
    /// DEPRECATED. This field is DEPRECATED. Please find the time data in the 'time' field under the 'network_transaction_reference' object instead of the 'verification' object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time")]
    public string? Time { get; init; }

    /// <summary>
    /// The currency and amount for a financial transaction, such as a balance or payment due.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Money? Amount { get; init; }

    /// <summary>
    /// The processor response information for payment requests, such as direct credit card transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processor_response")]
    public CardVerificationProcessorResponse? ProcessorResponse { get; init; }

    /// <summary>
    /// DEPRECATED. This field is DEPRECATED. Please find the 3D secure authentication data in the 'three_d_secure' object under the 'authentication_result' object instead of the 'verification' object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("three_d_secure")]
    public object? ThreeDSecure { get; init; }
}
