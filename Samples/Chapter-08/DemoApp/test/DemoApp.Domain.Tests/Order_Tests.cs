using System;
using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Data;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace DemoApp
{
    public class Order_Tests : DemoAppDomainTestBase
    {
        [Fact]
        public async Task Data_Filter_Tests()
        {
            var dataFilter = GetRequiredService<IDataFilter>();
            var orderRepository = GetRequiredService<IRepository<Order, Guid>>();

            await orderRepository.InsertManyAsync(
                new []
                {
                    new Order(),
                    new Order(),
                    new Order{ IsArchived = true }
                }
            );

            var orders = await orderRepository.GetListAsync();
            orders.Count.ShouldBe(2); //Archived orders are filtered!
            orders.ShouldNotContain(x => x.IsArchived);

            using (dataFilter.Disable<IArchivable>())
            {
                orders = await orderRepository.GetListAsync();
                orders.Count.ShouldBe(3); //Archived orders are also available since we've disabled the filter
                orders.ShouldContain(x => x.IsArchived);
            }
            
            orders = await orderRepository.GetListAsync();
            orders.Count.ShouldBe(2); //Archived orders are filtered, because the using scope ends
            orders.ShouldNotContain(x => x.IsArchived);
        }
    }
}