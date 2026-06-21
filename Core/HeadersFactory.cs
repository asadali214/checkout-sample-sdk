using System.Collections.Generic;
using System.Linq;
using PayPalServerSdk.Core.Models;

namespace PayPalServerSdk.Core;

internal sealed class HeadersFactory
{
    private readonly IReadOnlyCollection<HeaderParam> _defaultHeaders;

    public HeadersFactory(IReadOnlyCollection<HeaderParam> defaultHeaders) =>
        _defaultHeaders = defaultHeaders;

    public IReadOnlyCollection<HeaderParam> Create(IReadOnlyCollection<HeaderParam> headerParameters) =>
        _defaultHeaders.Concat(headerParameters).ToList();
}