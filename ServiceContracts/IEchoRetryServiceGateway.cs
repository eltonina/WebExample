using System.Threading.Tasks;
using Web.Example.Models;

namespace Web.Example.ServiceContracts
{
    public interface IEchoRetryServiceGateway
    {
        Task<EchoEmptyResponseModel> GetWithRetry();
    }
}