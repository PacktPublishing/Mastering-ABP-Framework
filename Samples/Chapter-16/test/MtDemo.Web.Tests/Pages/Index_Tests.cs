using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MtDemo.Pages
{
    public class Index_Tests : MtDemoWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
