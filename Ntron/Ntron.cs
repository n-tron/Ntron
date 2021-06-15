using Microsoft.Extensions.DependencyInjection;
using Ntron.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntron
{
    public interface INtron
    {
        string Url { get; set; }
        string APIKey { get; set; }
    }
    public class Ntron : INtron
    {
        public string Url { get; set; }
        public string APIKey { get; set; }
    }

    public static class Configuration
    {
        public static void AddNtron(this IServiceCollection services, Action<INtron> configAction)
        {

            Ntron ntron = new Ntron();
            configAction(ntron);

            services.AddSingleton<INtron>(ntron);
            services.AddHttpClient();
            services.AddScoped<IAddressUtilitiesProvider, AddressUtilitiesProvider>();
        }
    }
}
