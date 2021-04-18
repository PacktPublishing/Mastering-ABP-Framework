using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Linq;

namespace FormsApp
{
    public class FormService3 : ITransientDependency
    {
        private readonly IFormRepository _formRepository;
        private readonly IAsyncQueryableExecuter _asyncExecuter;

        public FormService3(
            IFormRepository formRepository,
            IAsyncQueryableExecuter asyncExecuter)
        {
            _formRepository = formRepository;
            _asyncExecuter = asyncExecuter;
        }

        public async Task<List<Form>> GetFormsAsync(string name)
        {
            return await _formRepository
                .GetListAsync(name, includeDrafts: true);
        }

        public async Task<IEnumerable<Question>> GetQuestionsAsync(Guid formId)
        {
            var form = await _formRepository.GetAsync(formId);
            await _formRepository.EnsureCollectionLoadedAsync(form, f => f.Questions);
            return form.Questions;
        }
        
        public async Task EagerLoadDemoAsync(Guid formId)
        {
            var queryable = await _formRepository.WithDetailsAsync(f => f.Questions);
            var query = queryable.Where(f => f.Id == formId);
            var form = await _asyncExecuter.FirstOrDefaultAsync(query);
            foreach (var question in form.Questions)
            {
                //...
            }
        }

        public async Task LoadingWithDetailsAsync(string name)
        {
            var forms = await _formRepository.GetListAsync(f => f.Name.StartsWith("A"), includeDetails: true);
        }
    }
}