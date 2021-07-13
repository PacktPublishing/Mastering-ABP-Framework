using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.Crm.Pages
{
    public class Index_Tests : CrmWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
