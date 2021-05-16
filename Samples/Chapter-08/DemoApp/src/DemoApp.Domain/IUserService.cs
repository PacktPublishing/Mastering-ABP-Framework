using System;
using System.Threading.Tasks;

namespace DemoApp
{
    /// <summary>
    /// This is a custom service to get data for a user.
    /// You can implement it based on your custom logic.
    /// </summary>
    public interface IUserService
    {
        Task<string> GetSocialSecurityNumberAsync(Guid userId);
    }
}