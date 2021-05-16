using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace DemoApp
{
    public class OrderService : ITransientDependency
    {
        private readonly IRepository<Order, Guid> _orderRepository;
        private readonly IDataFilter _dataFilter;

        public OrderService(
            IRepository<Order, Guid> orderRepository,
            IDataFilter dataFilter)
        {
            _orderRepository = orderRepository;
            _dataFilter = dataFilter;
        }

        public async Task<List<Order>> GetAllOrders()
        {
            using (_dataFilter.Disable<ISoftDelete>())
            {
                return await _orderRepository.GetListAsync();
            }
        }
    }
}