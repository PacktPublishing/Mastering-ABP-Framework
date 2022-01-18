using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProductManagement.Products;

namespace ProductManagement.Web.Pages.Products
{
    public class EditProductModalModel : ProductManagementPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditProductViewModel Product { get; set; }
        public SelectListItem[] Categories { get; set; }

        private readonly IProductAppService _productAppService;

        public EditProductModalModel(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        public async Task OnGetAsync()
        {
            var productDto = await _productAppService.GetAsync(Id);
            Product = ObjectMapper.Map<ProductDto, CreateEditProductViewModel>(productDto);

            var categoryLookup = await _productAppService.GetCategoriesAsync();
            Categories = categoryLookup.Items
                .Select(x => new SelectListItem(x.Name, x.Id.ToString()))
                .ToArray();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _productAppService.UpdateAsync(
                Id,
                ObjectMapper.Map<CreateEditProductViewModel, CreateUpdateProductDto>(Product)
            );
            return NoContent();
        }
    }
}
