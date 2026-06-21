using System.Text.Json.Serialization;
using PayPalServerSdk.Models.Enums;

namespace PayPalServerSdk.Models;

/// <summary>
/// Customizes the payer experience during the approval process for the BLIK payment.
/// </summary>
public record BlikExperienceContext
{
    /// <summary>
    /// The label that overrides the business name in the PayPal account on the PayPal site. The pattern is defined by an external party and supports Unicode.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brand_name")]
    public string? BrandName { get; init; }

    /// <summary>
    /// The <see href="https://tools.ietf.org/html/bcp47#section-2">language tag</see> for the language in which to localize the error-related strings, such as messages, issues, and suggested actions. The tag is made up of the <see href="https://www.loc.gov/standards/iso639-2/php/code_list.php">ISO 639-2 language code</see>, the optional <see href="https://www.unicode.org/iso15924/codelists.html">ISO-15924 script tag</see>, and the <see href="/api/rest/reference/country-codes/">ISO-3166 alpha-2 country code</see> or <see href="https://unstats.un.org/unsd/methodology/m49/">M49 region code</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locale")]
    public string? Locale { get; init; }

    /// <summary>
    /// The location from which the shipping address is derived.
    /// </summary>
    [JsonPropertyName("shipping_preference")]
    public ExperienceContextShippingPreference? ShippingPreference { get; init; } = ExperienceContextShippingPreference.GetFromFile;

    /// <summary>
    /// Describes the URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("return_url")]
    public string? ReturnUrl { get; init; }

    /// <summary>
    /// Describes the URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancel_url")]
    public string? CancelUrl { get; init; }

    /// <summary>
    /// An Internet Protocol address (IP address). This address assigns a numerical label to each device that is connected to a computer network through the Internet Protocol. Supports IPv4 and IPv6 addresses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consumer_ip")]
    public string? ConsumerIp { get; init; }

    /// <summary>
    /// The payer's User Agent. For example, Mozilla/5.0 (Macintosh; Intel Mac OS X x.y; rv:42.0).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consumer_user_agent")]
    public string? ConsumerUserAgent { get; init; }
}
