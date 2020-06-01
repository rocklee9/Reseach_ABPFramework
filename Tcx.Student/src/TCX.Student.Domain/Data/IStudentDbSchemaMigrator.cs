using System.Threading.Tasks;

namespace TCX.Student.Data
{
    public interface IStudentDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
