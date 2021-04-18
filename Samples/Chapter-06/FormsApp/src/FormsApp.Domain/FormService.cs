using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace FormsApp
{
    public class FormService : ITransientDependency
    {
        private readonly IRepository<Form, Guid> _formRepository;

        public FormService(IRepository<Form, Guid> formRepository)
        {
            _formRepository = formRepository;
        }

        public async Task<List<Form>> GetDraftForms()
        {
            return await _formRepository
                .GetListAsync(f => f.IsDraft);
        }

        public async Task FooAsync()
        {
            // Insert a new entity
            var form = new Form(); // TODO: set the form properties
            await _formRepository.InsertAsync(form, autoSave: true);

            // Delete entities with a condition 
            await _formRepository.DeleteAsync(form => form.IsDraft);
        }

        public async Task<Form> GetAsync(string name)
        {
            return await _formRepository.GetAsync(form => form.Name == name);
        }

        public async Task<List<Form>> GetFormsAsync(string name)
        {
            return await _formRepository.GetListAsync(form => form.Name.Contains(name));
        }
    }
}