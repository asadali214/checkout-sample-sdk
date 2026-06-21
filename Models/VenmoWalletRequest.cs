using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// Information needed to pay using Venmo.
/// </summary>
public record VenmoWalletRequest
{
    /// <summary>
    /// The PayPal-generated ID for the vaulted payment source. This ID should be stored on the merchant's server so the saved payment source can be used for future transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vault_id")]
    public string? VaultId { get; init; }

    /// <summary>
    /// The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// Customizes the buyer experience during the approval process for payment with Venmo. Note: Partners and Marketplaces might configure shipping_preference during partner account setup, which overrides the request values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("experience_context")]
    public VenmoWalletExperienceContext? ExperienceContext { get; init; }

    /// <summary>
    /// Additional attributes associated with the use of this Venmo Wallet.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attributes")]
    public VenmoWalletAdditionalAttributes? Attributes { get; init; }
}
