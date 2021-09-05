using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MvcDemo.Web.Pages
{
    public class CreateMovieModel : AbpPageModel
    {
        [BindProperty]
        public MovieViewModel Movie { get; set; }
        
        public void OnGet()
        {
            Movie = new MovieViewModel();
        }

        public async Task OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                //TODO: Create a new movie
            }
            else
            {
                Alerts.Danger("Please correct the form fields!");
            }
        }
    }
}