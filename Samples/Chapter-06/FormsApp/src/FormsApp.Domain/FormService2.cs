using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Linq;

namespace FormsApp
{
    public class FormService2 : ITransientDependency
    {
        private readonly IRepository<Form, Guid> _formRepository;
        private readonly IAsyncQueryableExecuter _asyncExecuter;

        public FormService2(
            IRepository<Form, Guid> formRepository,
            IAsyncQueryableExecuter asyncExecuter)
        {
            _formRepository = formRepository;
            _asyncExecuter = asyncExecuter;
        }

        public async Task<List<Form>> GetOrderedFormsAsync(string name)
        {
            // Obtain an IQueryable<Form>
            var queryable = await _formRepository.GetQueryableAsync();

            // Write your LINQ
            var query = from form in queryable
                where form.Name.Contains(name)
                orderby form.Name
                select form;

            // Use IAsyncQueryableExecuter to execute it
            return await _asyncExecuter.ToListAsync(query);
        }

        public async Task<List<Form>> GetOrderedForms2Async(string name)
        {
            // Obtain an IQueryable<Form>
            var queryable = await _formRepository.GetQueryableAsync();

            // Write your LINQ
            var query = queryable
                .Where(form => form.Name.Contains(name))
                .OrderBy(form => form.Name);

            // Use IAsyncQueryableExecuter to execute it
            return await _asyncExecuter.ToListAsync(query);
        }

        public async Task<int> GetCountAsync()
        {
            return await _formRepository
                .CountAsync(x => x.Name.StartsWith("A"));
        }
    }
}