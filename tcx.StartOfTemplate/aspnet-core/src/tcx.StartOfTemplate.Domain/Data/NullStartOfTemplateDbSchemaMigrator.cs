using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace tcx.StartOfTemplate.Data
{
    /* This is used if database provider does't define
     * IStartOfTemplateDbSchemaMigrator implementation.
     */
    public class NullStartOfTemplateDbSchemaMigrator : IStartOfTemplateDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}