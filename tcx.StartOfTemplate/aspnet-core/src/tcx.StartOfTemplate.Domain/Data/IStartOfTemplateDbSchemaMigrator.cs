using System.Threading.Tasks;

namespace tcx.StartOfTemplate.Data
{
    public interface IStartOfTemplateDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
