using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MvcDemo.Pages
{
    public class Index_Tests : MvcDemoWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
