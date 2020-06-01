using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Tcx.xdcb.Data
{
    /* This is used if database provider does't define
     * IxdcbDbSchemaMigrator implementation.
     */
    public class NullxdcbDbSchemaMigrator : IxdcbDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}