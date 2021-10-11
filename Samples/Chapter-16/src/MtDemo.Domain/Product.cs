using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace MtDemo
{
    public class Product : AggregateRoot<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; private set; }

        public string Name { get; private set; }

        public Product(
            Guid id,
            string name,
            Guid? tenantId) 
            : base(id)
        {
            Name = Check.NotNullOrWhiteSpace(name, nameof(name));
            TenantId = tenantId;
        }

        private Product()
        {
            /* private constructor is for ORMs */
        }
    }
}