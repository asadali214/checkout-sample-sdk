using System.Collections.Generic;
using PayPalServerSdk.Core.Models;

namespace PayPalServerSdk.Core.Authentication.OAuth2;

internal delegate IReadOnlyList<T> CredentialParamsFactory<out T>(string clientId, string? clientSecret);
