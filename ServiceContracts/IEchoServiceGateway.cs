using System.Threading.Tasks;
using Web.Example.Models;

namespace Web.Example.ServiceContracts
{
    public interface IEchoServiceGateway
    {
        Task<EchoEmptyResponseModel> GetWithoutQueryString();
    }
}
