using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Volo.Abp.DependencyInjection;

namespace SmsSending
{
    /* THIS IMPLEMENTATION GETS OPTIONS DIRECTLY FROM THE IConfiguration service
     
    public class AzureSmsService : ISmsService, ITransientDependency
    {
        private readonly IConfiguration _configuration;

        public AzureSmsService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public async Task SendAsync(string phoneNumber, string message)
        {
            string sender = _configuration["AzureSmsService:Sender"];
            string connStr = _configuration["AzureSmsService:ConnStr"];
            //TODO...
        }
    }
    
    */

    public class AzureSmsService : ISmsService, ITransientDependency
    {
        private readonly AzureSmsServiceOptions _options;

        public AzureSmsService(IOptions<AzureSmsServiceOptions> options)
        {
            _options = options.Value;
        }

        public async Task SendAsync(string phoneNumber, string message)
        {
            string sender = _options.Sender;
            string connStr = _options.ConnStr;
            //TODO...
        }
    }
}