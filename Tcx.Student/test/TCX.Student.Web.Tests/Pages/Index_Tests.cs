using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace TCX.Student.Pages
{
    public class Index_Tests : StudentWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
