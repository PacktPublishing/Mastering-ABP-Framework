using System;
using Volo.Abp.DependencyInjection;

namespace SimpleModularityDemo
{
    public class HelloWorldService : ITransientDependency
    {
        public void SayHello()
        {
            Console.WriteLine("\tHello World!");
        }
    }
}
