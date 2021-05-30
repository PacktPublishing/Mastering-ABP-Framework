using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

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

    public class UserService : IUserService, ITransientDependency
    {
        public Task<string> GetSocialSecurityNumberAsync(Guid userId)
        {
            return Task.FromResult("42");
        }
    }
}