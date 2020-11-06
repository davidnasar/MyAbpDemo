using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace QAManagement.Samples
{
    public interface ISampleAppService : IApplicationService
    {
        Task<SampleDto> GetAsync();

        Task<SampleDto> GetAuthorizedAsync();
    }
}
