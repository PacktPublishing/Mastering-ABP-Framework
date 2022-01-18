using AutoMapper;
using ProductManagement.Products;
using ProductManagement.Web.Pages.Products;

namespace ProductManagement.Web
{
    public class ProductManagementWebAutoMapperProfile : Profile
    {
        public ProductManagementWebAutoMapperProfile()
        {
            CreateMap<CreateEditProductViewModel, CreateUpdateProductDto>();
            CreateMap<ProductDto, CreateEditProductViewModel>();
        }
    }
}
