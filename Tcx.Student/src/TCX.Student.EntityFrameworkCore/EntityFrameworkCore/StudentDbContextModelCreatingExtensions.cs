using Microsoft.EntityFrameworkCore;
using TCX.Student.Schema;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace TCX.Student.EntityFrameworkCore
{
    public static class StudentDbContextModelCreatingExtensions
    {
        public static void ConfigureStudent(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

           

            //builder.Entity<StudentOfClass>(b =>
            //{
            //    b.ToTable(StudentConsts.DbTablePrefix + "StudentOfClass", StudentConsts.DbSchema);
            //    b.ConfigureByConvention(); 
            //});

            //builder.Entity<Class>(b =>
            //{
            //    b.ToTable(StudentConsts.DbTablePrefix + "Class", StudentConsts.DbSchema);
            //    b.ConfigureByConvention();
            //});
        }
    }
}