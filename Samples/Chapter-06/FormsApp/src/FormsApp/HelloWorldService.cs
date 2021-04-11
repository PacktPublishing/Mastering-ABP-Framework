using System;
using Volo.Abp.DependencyInjection;

namespace FormsApp
{
    public class HelloWorldService : ITransientDependency
    {
        public void SayHello()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
