using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace DemoApp
{
    public interface IOrderAppService : IApplicationService
    {
        Task CreateAsync(CreateOrderDto input);
        
        Task DeleteAsync(Guid id);
    }
}