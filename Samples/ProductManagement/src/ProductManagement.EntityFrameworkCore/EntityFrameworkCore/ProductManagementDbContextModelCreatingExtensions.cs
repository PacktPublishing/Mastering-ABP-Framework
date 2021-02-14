using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace ProductManagement.EntityFrameworkCore
{
    public static class ProductManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureProductManagement(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            //TODO: Map category & product
        }
    }
}