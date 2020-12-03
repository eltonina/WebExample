using System.Threading.Tasks;
using Web.Example.Models;

namespace Web.Example.ServiceContracts
{
    public interface IEchoCRUDServiceGateway
    {
        Task<EchoPostResponseModel> Post(EchoRequestModel echoRequest);
        Task<EchoPostResponseModel> Put(EchoRequestModel echoRequest);
        Task<EchoResponseModel> Get(EchoRequestModel echoRequest);
        Task Delete(EchoRequestModel echoRequest);
    }
}