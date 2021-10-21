using System;
using Volo.Abp.DependencyInjection;

namespace ModularityDemo
{
    public class HelloWorldService : ITransientDependency
    {
        public void SayHello()
        {
            Console.WriteLine("\tHello World!");
        }
    }
}
