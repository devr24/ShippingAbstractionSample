using Logistics.Shipping.Abstractions;
using Logistics.Shipping.Abstractions.Pudo;
using Logistics.Shipping.Providers.Dpd;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        // Can add Dpd Pudo only
        public static IServiceCollection AddDpdPudoProvider(this IServiceCollection services, string instanceName, DpdClientConfig config)
        {
            var instance = new DpdClient(new DpdClientConfig { 
                ApiKey = config.ApiKey
            });

            if (!string.IsNullOrEmpty(instanceName))
                instance.Name = instanceName;

            services.AddSingleton<IPudoProvider>(instance);
            services.AddFactoryIfNotAdded<IPudoProvider>();
            return services;
        }
        public static IServiceCollection AddDpdPudoProvider(this IServiceCollection services, DpdClientConfig config) => AddDpdPudoProvider(services, null, config); // shortcut method.

        // Can add Dpd Shipment only
        public static IServiceCollection AddDpdShipmentProvider(this IServiceCollection services, string instanceName, DpdClientConfig config)
        {
            var instance = new DpdClient(new DpdClientConfig
            {
                ApiKey = config.ApiKey
            });

            if (!string.IsNullOrEmpty(instanceName))
                instance.Name = instanceName;

            services.AddSingleton<IShipmentProvider>(instance);
            services.AddFactoryIfNotAdded<IShipmentProvider>();
            return services;
        }
        public static IServiceCollection AddDpdShipmentProvider(this IServiceCollection services, DpdClientConfig config) => AddDpdShipmentProvider(services, null, config); // shortcut method.

        // Can add Dpd Pudo and Shipment both
        public static IServiceCollection AddDpdServiceProviders(this IServiceCollection services, string instanceName, DpdClientConfig config)
        {
            var instance = new DpdClient(new DpdClientConfig
            {
                ApiKey = config.ApiKey
            });

            if (!string.IsNullOrEmpty(instanceName))
                instance.Name = instanceName;

            services.AddSingleton<IShipmentProvider>(instance);
            services.AddSingleton<IPudoProvider>(instance);
            services.AddFactoryIfNotAdded<IShipmentProvider>();
            services.AddFactoryIfNotAdded<IPudoProvider>();
            return services;
        }
        public static IServiceCollection AddDpdServiceProviders(this IServiceCollection services, DpdClientConfig config) => AddDpdServiceProviders(services, null, config); // shortcut method.
    }
}
