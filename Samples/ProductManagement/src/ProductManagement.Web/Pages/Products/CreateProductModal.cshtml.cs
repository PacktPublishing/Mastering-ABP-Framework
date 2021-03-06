using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProductManagement.Products;

namespace ProductManagement.Web.Pages.Products
{
    public class CreateProductModal : ProductManagementPageModel
    {
        [BindProperty]
        public CreateProductViewModel Product { get; set; }
        public SelectListItem[] Categories { get; set; }

        private readonly IProductAppService _productAppService;

        public CreateProductModal(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }
        
        public async Task OnGetAsync()
        {
            Product = new CreateProductViewModel
            {
                ReleaseDate = Clock.Now,
                StockState = ProductStockState.PreOrder
            };
            
            var categoryLookup = await _productAppService.GetCategoriesAsync();
            Categories = categoryLookup.Items
                .Select(x => new SelectListItem(x.Name, x.Id.ToString()))
                .ToArray();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _productAppService.CreateAsync(
                ObjectMapper
                    .Map<CreateProductViewModel, CreateProductDto>(Product)
            );
            return NoContent();
        }
    }
}