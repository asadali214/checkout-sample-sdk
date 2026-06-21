using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// The list of subscriptions.
/// </summary>
public record SubscriptionCollection
{
    /// <summary>
    /// An array of subscriptions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscriptions")]
    public IReadOnlyList<Subscription>? Subscriptions { get; init; }

    /// <summary>
    /// An array of request-related <see href="/docs/api/reference/api-responses/#hateoas-links">HATEOAS links</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("links")]
    public IReadOnlyList<LinkDescription>? Links { get; init; }
}
