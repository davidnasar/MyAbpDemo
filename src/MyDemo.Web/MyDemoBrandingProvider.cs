using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace MyDemo.Web
{
    [Dependency(ReplaceServices = true)]
    public class MyDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "MyDemo";
    }
}
