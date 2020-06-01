using System.Threading.Tasks;

namespace Tcx.xdcb.Data
{
    public interface IxdcbDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
