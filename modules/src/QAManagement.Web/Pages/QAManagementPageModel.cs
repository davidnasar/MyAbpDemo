using QAManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace QAManagement.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class QAManagementPageModel : AbpPageModel
    {
        protected QAManagementPageModel()
        {
            LocalizationResourceType = typeof(QAManagementResource);
            ObjectMapperContext = typeof(QAManagementWebModule);
        }
    }
}