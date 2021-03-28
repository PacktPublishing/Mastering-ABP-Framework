using System.Threading.Tasks;

namespace SmsSending
{
    public interface ISmsService
    {
        Task SendAsync(string phoneNumber, string message);
    }
}