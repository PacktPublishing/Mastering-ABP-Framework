using MongoDB.Driver;
using Volo.Abp.MongoDB;

namespace FormsApp
{
    public class FormsAppDbContext : AbpMongoDbContext
    {
        [MongoCollection("Forms")]
        public IMongoCollection<Form> Forms => Collection<Form>();

        protected override void CreateModel(IMongoModelBuilder builder)
        {
            builder.Entity<Form>(b =>
            {
                //b.BsonMap.UnmapProperty(f => f.Description);
            });
        }
    }
}