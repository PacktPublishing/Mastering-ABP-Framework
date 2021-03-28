using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SmsSending
{
    public class AzureSmsService : ISmsService, ITransientDependency
    {
        public async Task SendAsync(string phoneNumber, string message)
        {
            //TODO: ...
        }
    }
}