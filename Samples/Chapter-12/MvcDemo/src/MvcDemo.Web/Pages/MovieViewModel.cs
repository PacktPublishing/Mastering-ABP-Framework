using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace MvcDemo.Web.Pages
{
    public class MovieViewModel : IValidatableObject
    {
        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [TextArea]
        [StringLength(1000)]
        public string Description { get; set; }

        public Genre Genre { get; set; }

        public float? Price { get; set; }

        public bool PreOrder { get; set; }
        
        public IEnumerable<ValidationResult> Validate(
            ValidationContext validationContext)
        {
            if (PreOrder && Price > 999)
            {
                yield return new ValidationResult(
                    "Price should be lower than 999 for pre-order movies!",
                    new[] { nameof(Price) }
                );
            }
        }
    }
}