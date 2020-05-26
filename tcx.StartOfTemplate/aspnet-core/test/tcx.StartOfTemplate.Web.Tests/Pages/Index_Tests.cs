using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace tcx.StartOfTemplate.Pages
{
    public class Index_Tests : StartOfTemplateWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
