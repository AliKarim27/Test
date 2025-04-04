using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Test.Pages;

[Collection(TestTestConsts.CollectionDefinitionName)]
public class Index_Tests : TestWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
