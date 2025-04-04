using Microsoft.AspNetCore.Builder;
using Test;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("Test.Web.csproj"); 
await builder.RunAbpModuleAsync<TestWebTestModule>(applicationName: "Test.Web");

public partial class Program
{
}
