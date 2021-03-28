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
            var userName = _currentUser.UserName;
            var email = _currentUser.Email;
        }
    }
}