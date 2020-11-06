using QAManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace QAManagement.Pages
{
    public abstract class QAManagementPageModel : AbpPageModel
    {
        protected QAManagementPageModel()
        {
            LocalizationResourceType = typeof(QAManagementResource);
        }
    }
}