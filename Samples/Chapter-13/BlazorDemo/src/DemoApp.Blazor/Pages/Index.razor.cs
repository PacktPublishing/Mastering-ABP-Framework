using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace DemoApp.Blazor.Pages
{
    public partial class Index
    {
        [Inject]
        private ITestAppService TestAppService { get; set; }

        private int Value { get; set; }
        
        protected override async Task OnInitializedAsync()
        {
            Value = await TestAppService.GetDataAsync();
        }
    }
}