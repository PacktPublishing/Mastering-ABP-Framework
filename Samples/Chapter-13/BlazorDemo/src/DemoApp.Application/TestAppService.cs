using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace DemoApp
{
    public class TestAppService : ApplicationService, ITestAppService
    {
        public async Task<int> GetDataAsync()
        {
            return 42;
        }
    }
}