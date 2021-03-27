using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace DemoApp.Pages
{
    public class Index_Tests : DemoAppWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
