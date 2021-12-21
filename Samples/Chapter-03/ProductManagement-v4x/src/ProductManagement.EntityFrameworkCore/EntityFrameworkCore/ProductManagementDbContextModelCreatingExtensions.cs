using Microsoft.EntityFrameworkCore;
using ProductManagement.Categories;
using ProductManagement.Products;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ProductManagement.EntityFrameworkCore
{
    public static class ProductManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureProductManagement(
            this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

			builder.Entity<Category>(b =>
			{
				b.ToTable("Categories");
				b.ConfigureByConvention();
				b.Property(x => x.Name)
					.HasMaxLength(CategoryConsts.MaxNameLength)
					.IsRequired();
				b.HasIndex(x => x.Name).IsUnique();
			});

			builder.Entity<Product>(b =>
			{
				b.ToTable("Products");
				b.ConfigureByConvention();
				b.Property(x => x.Name)
					.HasMaxLength(ProductConsts.MaxNameLength)
					.IsRequired();
				b.HasOne(x => x.Category)
					.WithMany()
					.HasForeignKey(x => x.CategoryId)
					.OnDelete(DeleteBehavior.Restrict)
					.IsRequired();
				b.HasIndex(x => x.Name);
			});
		}
	}
}
