using Tcx.BookStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Tcx.BookStore
{
    [DependsOn(
        typeof(BookStoreEntityFrameworkCoreTestModule)
        )]
    public class BookStoreDomainTestModule : AbpModule
    {

    }
}