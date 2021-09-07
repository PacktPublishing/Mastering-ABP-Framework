using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MvcDemo.Web.Pages
{
    public class ModalWithForm : AbpPageModel
    {
        [BindProperty]
        public MovieViewModel Movie { get; set; }
        
        public void OnGet()
        {
            Movie = new MovieViewModel();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            ValidateModel();
            //TODO: Create a new movie
            return Content("42");
        }
    }
}