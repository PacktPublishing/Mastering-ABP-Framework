using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;

namespace FormsApp
{
    public class FormServiceWithUow : ITransientDependency
    {
        private readonly IRepository<Form, Guid> _formRepository;

        public FormServiceWithUow(IRepository<Form, Guid> formRepository)
        {
            _formRepository = formRepository;
        }

        [UnitOfWork(isTransactional: true)]
        public async Task DoItAsync()
        {
            await _formRepository.InsertAsync(new Form() { });
            await _formRepository.InsertAsync(new Form() { });
        }
    }

    public class FormServiceWithUowManager : ITransientDependency
    {
        private readonly IRepository<Form, Guid> _formRepository;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public FormServiceWithUowManager(
            IRepository<Form, Guid> formRepository,
            IUnitOfWorkManager unitOfWorkManager)
        {
            _formRepository = formRepository;
            _unitOfWorkManager = unitOfWorkManager;
        }

        public async Task DoItAsync()
        {
            using (var uow = _unitOfWorkManager.Begin(
                requiresNew: true,
                isTransactional: true,
                timeout: 15000))
            {
                await _formRepository.InsertAsync(new Form() { });
                await _formRepository.InsertAsync(new Form() { });

                await uow.RollbackAsync();
            }
        }

        public async Task DoIt2Async()
        {
            await _unitOfWorkManager.Current.SaveChangesAsync();
        }
    }
}