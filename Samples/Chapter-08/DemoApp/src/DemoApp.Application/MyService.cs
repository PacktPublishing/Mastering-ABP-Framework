using System;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Users;
namespace DemoApp
{
    public class MyService : ITransientDependency
    {
        private readonly ICurrentUser _currentUser;

        public MyService(ICurrentUser currentUser)
        {
            _currentUser = currentUser;
        }

        public void Demo()
        {
            Guid? userId = _currentUser.Id;
            string userName = _currentUser.UserName;
            string email = _currentUser.Email;
        }
    }
}