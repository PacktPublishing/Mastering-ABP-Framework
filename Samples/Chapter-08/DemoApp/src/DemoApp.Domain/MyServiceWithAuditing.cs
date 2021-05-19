using System;
using System.Threading.Tasks;
using Volo.Abp.Auditing;
using Volo.Abp.DependencyInjection;

namespace DemoApp
{
    public class MyServiceWithAuditing : ITransientDependency
    {
        private readonly IAuditingManager _auditingManager;

        public MyServiceWithAuditing(IAuditingManager auditingManager)
        {
            _auditingManager = auditingManager;
        }

        public async Task DoItAsync()
        {
            using (var auditingScope = _auditingManager.BeginScope())
            {
                try
                {
                    //TODO: call other services...
                }
                catch (Exception ex)
                {
                    _auditingManager.Current.Log.Exceptions.Add(ex);
                    throw;
                }
                finally
                {
                    await auditingScope.SaveAsync();
                }
            }
        }
    }
}