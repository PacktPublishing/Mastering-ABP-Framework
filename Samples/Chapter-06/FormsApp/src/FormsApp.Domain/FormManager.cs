using System;
using Volo.Abp.Domain.Entities;

namespace FormsApp
{
    public class FormManager : Entity
    {
        public Guid FormId { get; set; }
        public Guid UserId { get; set; }
        public Guid IsOwner { get; set; }

        public override object[] GetKeys()
        {
            return new object[] {FormId, UserId};
        }
    }
}