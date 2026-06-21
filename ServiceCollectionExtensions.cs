using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;

namespace PayPalServerSdk;

public static class ServiceCollectionExtensions
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddPayPalServerSdkClient(Action<PayPalServerSdkClientOptions>? configure = null)
        {
            var options = new PayPalServerSdkClientOptions();
            configure?.Invoke(options);
            services.AddHttpClient();
            services.AddTransient(sp =>
                {
                    var httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
                    var httpClient = httpClientFactory.CreateClient();
                    return new PayPalServerSdkClient(httpClient, options);
                });
            return services;
        }
    }
}
