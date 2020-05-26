using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Tcx.Student.EntityFrameworkCore
{
    public static class StudentDbContextModelCreatingExtensions
    {
        public static void ConfigureStudent(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(StudentConsts.DbTablePrefix + "YourEntities", StudentConsts.DbSchema);

            //    //...
            //});
        }
    }
}