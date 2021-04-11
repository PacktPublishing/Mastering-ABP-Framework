using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace FormsApp
{
    public class Question : Entity<Guid>
    {
        public Guid FormId { get; set; }
        public string Title { get; set; }
        public bool AllowMultiSelect { get; set; }
        public ICollection<Option> Options { get; set; }
    }
}