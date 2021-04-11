using System;
using Volo.Abp.Domain.Entities;

namespace FormsApp
{
    public class Option : Entity<Guid>
    {
        public string Text { get; set; }
    }
}