using System.Threading.Tasks;
using Abp.Application.Services;
using Evol.Ant.Sessions.Dto;

namespace Evol.Ant.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
