using QAManagement.Localization;
using Volo.Abp.Application.Services;

namespace QAManagement
{
    public abstract class QAManagementAppService : ApplicationService
    {
        protected QAManagementAppService()
        {
            LocalizationResource = typeof(QAManagementResource);
            ObjectMapperContext = typeof(QAManagementApplicationModule);
        }
    }
}
