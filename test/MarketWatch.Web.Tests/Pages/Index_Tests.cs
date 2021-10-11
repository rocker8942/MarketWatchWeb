using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MarketWatch.Pages
{
    public class Index_Tests : MarketWatchWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
