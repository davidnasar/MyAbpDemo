using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MyDemo.Pages
{
    public class Index_Tests : MyDemoWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
