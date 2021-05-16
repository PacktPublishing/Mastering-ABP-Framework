using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace DemoApp
{
    public class Order : AggregateRoot<Guid>, ISoftDelete, IMultiTenant
    {
        public bool IsDeleted { get; set; }
        public Guid? TenantId { get; set; }
        //...other properties
    }
}