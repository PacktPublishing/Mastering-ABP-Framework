using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MvcDemo.Web.Pages
{
    public class MySimpleModalModel : AbpPageModel
    {
        public string Message { get; set; }
        
        public void OnGet(int productId)
        {
            Message = "Hello modals! " + productId;
        }
    }
}