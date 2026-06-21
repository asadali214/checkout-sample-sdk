using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The store information.
/// </summary>
public record StoreInformation
{
    /// <summary>
    /// The ID of a store for a merchant in the system of record.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("store_id")]
    public string? StoreId { get; init; }

    /// <summary>
    /// The terminal ID for the checkout stand in a merchant store.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminal_id")]
    public string? TerminalId { get; init; }
}
