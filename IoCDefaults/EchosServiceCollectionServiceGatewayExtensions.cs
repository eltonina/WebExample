using Web.Example.Configuration;
using Web.Example.ServiceContracts; 
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Web.Client.IoC;

namespace Web.Example.IoCDefaults
{
    public static class EchosServiceCollectionServiceGatewayExtensions
    {

        // if you want a more simpler registration you can create your own IServiceCollection extension 
        // with all services registration required by your ServiceGateways
        public static void RegisterEchoServiceGateways(this IServiceCollection serviceCollection)
        {
            serviceCollection.TryAddServiceGatewayConfiguration<EchoServiceGatewayClientsConfiguration>();
            serviceCollection.TryAddSingleton<IEchoServiceGateway, IEchoServiceGateway>();
            serviceCollection.TryAddSingleton<IEchoCRUDServiceGateway, IEchoCRUDServiceGateway>();
        }

    }
}
