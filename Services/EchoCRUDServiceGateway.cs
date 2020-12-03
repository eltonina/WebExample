using Web.Client;
using Web.Example.Configuration;
using Web.Example.Models;
using Web.Example.ServiceContracts;
using System.Net.Http;
using System.Threading.Tasks;

namespace Web.Example.Services
{
    public class EchoCRUDServiceGateway : IEchoCRUDServiceGateway
    {

        // The instance of your client created by the factory
        private readonly IServiceGatewayClient _client;

        // You must allow the injection of your config class and the Factory that create the client
        public EchoCRUDServiceGateway(
            IServiceGatewayClientFactory serviceGatewayClientFactory,
            EchoServiceGatewayClientsConfiguration configuration)
        {
            _client = serviceGatewayClientFactory.CreateServiceGatewayClient(configuration);
        }

        public Task<EchoPostResponseModel> Post(EchoRequestModel echoRequest)
        {
            // Create the HttpRequest with post verb and no query string
            HttpRequestMessage Request() => _client.CreatePost("post", echoRequest);
            // Send your request and receive the response deserialized using the specified type
            return _client.SendAsync<EchoPostResponseModel>(Request);
        }

        public Task<EchoPostResponseModel> Put(EchoRequestModel echoRequest)
        {
            // Create the HttpRequest with put verb and no query string
            HttpRequestMessage Request() => _client.CreatePut("put", echoRequest);
            // Send your request and receive the response deserialized using the specified type
            return _client.SendAsync<EchoPostResponseModel>(Request);
        }

        public Task<EchoResponseModel> Get(EchoRequestModel echoRequest)
        {
            // Create the HttpRequest with get verb, the request model will be serialized in query string
            HttpRequestMessage Request() => _client.CreateGet("get", echoRequest);
            // Send your request and receive the response deserialized using the specified type
            return _client.SendAsync<EchoResponseModel>(Request);
        }

        public Task Delete(EchoRequestModel echoRequest)
        {
            // Create the HttpRequest with get verb, the request model will be serialized in query string
            HttpRequestMessage Request() => _client.CreateDelete("delete", echoRequest);
            // Send your request and receive the response deserialized using the specified type
            return _client.SendAsync(Request);
        }
    }
}