using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace DemoApp
{
    public interface ITestAppService : IApplicationService
    {
        Task<int> GetDataAsync();
    }
}