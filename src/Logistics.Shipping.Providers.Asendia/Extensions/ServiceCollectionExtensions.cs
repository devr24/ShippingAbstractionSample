using Logistics.Shipping.Abstractions;
using Logistics.Shipping.Abstractions.Pudo;
using Logistics.Shipping.Providers.Asendia;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        // Can add Asendia Pudo only
        public static IServiceCollection AddAsendiaPudoProvider(this IServiceCollection services, string instanceName = null)
        {
            var instance = new AsendiaPudoClient();

            if (!string.IsNullOrEmpty(instanceName))
                instance.Name = instanceName;

            services.AddSingleton<IPudoProvider>(instance);

            // This is needed for the factory class wireup.
            services.AddFactoryIfNotAdded<IPudoProvider>();

            return services;
        }

        // Can add Asendia Shipment only
        public static IServiceCollection AddAsendiaShipmentProvider(this IServiceCollection services, string instanceName = null)
        {
            var instance = new AsendiaShipmentClient();

            if (!string.IsNullOrEmpty(instanceName))
                instance.Name = instanceName;

            services.AddSingleton<IShipmentProvider>(instance);

            // This is needed for the factory class wireup.
            services.AddFactoryIfNotAdded<IShipmentProvider>();

            return services;
        }


        // Can add Dpd Pudo and Shipment both
        public static IServiceCollection AddAsendiaServiceProviders(this IServiceCollection services, string instanceName = null)
        {
            var pudoInstance = new AsendiaPudoClient();
            var shipmentInstance = new AsendiaShipmentClient();

            if (!string.IsNullOrEmpty(instanceName))
                pudoInstance.Name = instanceName;

            if (!string.IsNullOrEmpty(instanceName))
                shipmentInstance.Name = instanceName;

            services.AddSingleton<IShipmentProvider>(shipmentInstance);
            services.AddSingleton<IPudoProvider>(pudoInstance);

            // This is needed for the factory class wireup.
            services.AddFactoryIfNotAdded<IShipmentProvider>();
            services.AddFactoryIfNotAdded<IPudoProvider>();
            return services;
        }
    }
}
