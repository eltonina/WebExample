using Configuration.Contracts;
using Web.Client.Configurations;

namespace Web.Example.Configuration
{
    // You must create a configuration class inherited from ServiceGatewayClientsConfiguration
    // and set the configName in the constructor base, this configName will be use to create the 
    // unique HttpClient instance shared across the Service Gateways that share the same configuration.
    // In order to use the retry policy inject ANY class that implements the IRetryPolicyConfiguration
    // interface or the RetryPolicyDefaultConfiguration
    public class EchoRetryServiceGatewayClientsConfiguration : ServiceGatewayClientsConfiguration
    {
        public EchoRetryServiceGatewayClientsConfiguration(ISettingsRepository configuration,
            EchoRetryRetryPolicyConfiguration retryRetryPolicyConfiguration)
            : base("EchoRetry", configuration, retryRetryPolicyConfiguration)
        {
        }
    }
}