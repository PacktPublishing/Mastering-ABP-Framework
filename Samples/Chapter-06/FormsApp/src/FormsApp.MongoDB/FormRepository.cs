using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Volo.Abp.Domain.Repositories.MongoDB;
using Volo.Abp.MongoDB;

namespace FormsApp
{
    public class FormRepository :
        MongoDbRepository<FormsAppDbContext, Form, Guid>,
        IFormRepository
    {
        public FormRepository(
            IMongoDbContextProvider<FormsAppDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<List<Form>> GetListAsync(
            string name, bool includeDrafts = false)
        {
            /*
            FormsAppDbContext dbContext = await GetDbContextAsync();
            IMongoCollection<Form> formsCollection = await GetCollectionAsync();
            */

            var queryable = await GetMongoQueryableAsync();
            var query = queryable.Where(f => f.Name.Contains(name));
            if (!includeDrafts)
            {
                query = queryable.Where(f => !f.IsDraft);
            }

            return await query.ToListAsync();
        }
    }
}