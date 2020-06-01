using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TCX.Student.Data
{
    /* This is used if database provider does't define
     * IStudentDbSchemaMigrator implementation.
     */
    public class NullStudentDbSchemaMigrator : IStudentDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}