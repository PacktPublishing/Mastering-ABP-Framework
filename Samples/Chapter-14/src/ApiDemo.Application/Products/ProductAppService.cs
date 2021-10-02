using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace ApiDemo.Products
{
    public class ProductAppService : ApiDemoAppService, IProductAppService
    {
        public Task<ProductDto> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid id, ProductUpdateDto input)
        {
            throw new NotImplementedException();
        }
    }
}
