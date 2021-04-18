using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FormsApp
{
    public class FormRepository :
        EfCoreRepository<FormsAppDbContext, Form, Guid>,
        IFormRepository
    {
        public FormRepository(
            IDbContextProvider<FormsAppDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<List<Form>> GetListAsync(
            string name, bool includeDrafts = false)
        {
            var dbContext = await GetDbContextAsync();

            var query = dbContext.Forms
                .Where(f => f.Name.Contains(name));

            if (!includeDrafts)
            {
                query = query.Where(f => !f.IsDraft);
            }

            return await query.ToListAsync();
        }

        public async Task<List<Form>> GetList2Async(
            string name, bool includeDrafts = false)
        {
            var dbContext = await GetDbContextAsync();
            return await dbContext.Forms
                .Where(f => f.Name.Contains(name))
                .WhereIf(!includeDrafts, f => !f.IsDraft)
                .ToListAsync();
        }

        public async Task<Form> GetWithQuestions(Guid formId)
        {
            var dbContext = await GetDbContextAsync();
            return await dbContext.Forms
                .Include(f => f.Questions)
                .SingleAsync(f => f.Id == formId);
        }
    }
}