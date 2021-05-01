using System;
using Volo.Abp.Domain.Entities;

namespace ProductManagement.Products
{
    public class Product : AggregateRoot<Guid>
    {
        public string Name { get; set; }
        public Guid OwnerId { get; set; }
    }
}