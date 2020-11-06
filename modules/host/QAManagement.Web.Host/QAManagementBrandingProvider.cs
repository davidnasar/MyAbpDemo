using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace QAManagement
{
    [Dependency(ReplaceServices = true)]
    public class QAManagementBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "QAManagement";
    }
}
