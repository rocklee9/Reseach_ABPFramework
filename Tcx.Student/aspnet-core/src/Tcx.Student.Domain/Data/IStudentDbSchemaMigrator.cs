using System.Threading.Tasks;

namespace Tcx.Student.Data
{
    public interface IStudentDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
