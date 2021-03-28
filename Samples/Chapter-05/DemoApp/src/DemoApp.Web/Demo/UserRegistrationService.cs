using System.Threading.Tasks;
using SmsSending;

namespace DemoApp.Web.Demo
{
    public class UserRegistrationService
    {
        private readonly ISmsService _smsService;

        public UserRegistrationService(ISmsService smsService)
        {
            _smsService = smsService;
        }

        public async Task RegisterAsync(
            string username,
            string password,
            string phoneNumber)
        {
            //...save user in the database
            await _smsService.SendAsync(
                phoneNumber,
                "Your verification code: 1234"
            );
        }
    }
}