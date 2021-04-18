using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace FormsApp
{
    public interface IFormRepository : IRepository<Form, Guid>
    {
        Task<List<Form>> GetListAsync(
            string name,
            bool includeDrafts = false
        );
    }
}