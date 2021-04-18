using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace FormsApp
{
    public class FormsAppDbContext : AbpDbContext<FormsAppDbContext>
    {
        public DbSet<Form> Forms { get; set; }

        public FormsAppDbContext(DbContextOptions<FormsAppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Form>(b =>
            {
                b.ToTable("Forms");
                b.ConfigureByConvention();
                b.Property(x => x.Name)
                    .HasMaxLength(100)
                    .IsRequired();
                b.HasIndex(x => x.Name);
            });

            builder.Entity<Question>(b =>
            {
                b.ToTable("FormQuestions");
                b.ConfigureByConvention();
                b.Property(x => x.Title)
                    .HasMaxLength(200)
                    .IsRequired();
                b.HasOne<Form>()
                    .WithMany(x => x.Questions)
                    .HasForeignKey(x => x.FormId)
                    .IsRequired();
            });
        }
    }
}