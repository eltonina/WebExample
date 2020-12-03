using System;
using System.Threading.Tasks; 
using Web.Client;
using Web.Example.Configuration;
using Web.Example.Models;
using Web.Example.ServiceContracts;
using System.Net.Http;

namespace Web.Example.Services
{
    public class EchoServiceGateway : IEchoServiceGateway
    {
        // The instance of your client created by the factory
        private readonly IServiceGatewayClient _client;

        // You must allow the injection of your config class and the Factory that create the client
        public EchoServiceGateway(
            IServiceGatewayClientFactory serviceGatewayClientFactory,
            EchoServiceGatewayClientsConfiguration configuration)
        {
            _client = serviceGatewayClientFactory.CreateServiceGatewayClient(configuration);
        }

        public Task<EchoEmptyResponseModel> GetWithoutQueryString()
        {
            // Create the HttpRequest with get verb and no query string
            HttpRequestMessage Request() => _client.CreateGet("get");
            // Send your request and receive the response deserialized using the specified type
            return _client.SendAsync<EchoEmptyResponseModel>(Request);
        } 
    }
}