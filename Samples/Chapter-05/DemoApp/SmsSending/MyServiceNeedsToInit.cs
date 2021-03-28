using Volo.Abp.DependencyInjection;

namespace SmsSending
{
    public class MyServiceNeedsToInit : ISingletonDependency
    {
        public void Initialize()
        {
            //TODO: ...
        }
    }
}