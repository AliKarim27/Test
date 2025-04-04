using Test.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Test.Web.Pages;

public abstract class TestPageModel : AbpPageModel
{
    protected TestPageModel()
    {
        LocalizationResourceType = typeof(TestResource);
    }
}
