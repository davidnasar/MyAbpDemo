using QAManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace QAManagement
{
    public abstract class QAManagementController : AbpController
    {
        protected QAManagementController()
        {
            LocalizationResource = typeof(QAManagementResource);
        }
    }
}
