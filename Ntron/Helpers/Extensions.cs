using Microsoft.Extensions.DependencyInjection;
using Ntron.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntron.Helpers
{
    public static class Extensions
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
