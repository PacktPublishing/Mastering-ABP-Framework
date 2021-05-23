using System;
using Volo.Abp;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace DemoApp
{
    [Audited]
    public class Order : AggregateRoot<Guid>, ISoftDelete, IMultiTenant, IArchivable
    {
        public bool IsDeleted { get; set; }
        public Guid? TenantId { get; set; }
        public bool IsArchived { get; set; }
        //...other properties
    }
}