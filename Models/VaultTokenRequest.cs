using System.Text.Json.Serialization;
using PayPalServerSdk.Models.Enums;

namespace PayPalServerSdk.Models;

/// <summary>
/// The Tokenized Payment Source representing a Request to Vault a Token.
/// </summary>
public record VaultTokenRequest
{
    /// <summary>
    /// The PayPal-generated ID for the token.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The tokenization method that generated the ID.
    /// </summary>
    [JsonPropertyName("type")]
    public required VaultTokenRequestType Type { get; init; }
}
