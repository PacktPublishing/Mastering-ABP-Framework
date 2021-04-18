using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace FormsApp
{
    public class FormManagementService : ITransientDependency
    {
        private readonly IRepository<FormManager> _formManagerRepository;

        public FormManagementService(
            IRepository<FormManager> formManagerRepository)
        {
            _formManagerRepository = formManagerRepository;
        }

        public async Task<List<FormManager>> GetManagersAsync(Guid formId)
        {
            return await _formManagerRepository
                .GetListAsync(fm => fm.FormId == formId);
        }
    }
}