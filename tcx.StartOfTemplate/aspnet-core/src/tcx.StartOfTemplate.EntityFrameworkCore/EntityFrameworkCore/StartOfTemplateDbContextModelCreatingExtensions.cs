using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace tcx.StartOfTemplate.EntityFrameworkCore
{
    public static class StartOfTemplateDbContextModelCreatingExtensions
    {
        public static void ConfigureStartOfTemplate(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(StartOfTemplateConsts.DbTablePrefix + "YourEntities", StartOfTemplateConsts.DbSchema);

            //    //...
            //});
        }
    }
}