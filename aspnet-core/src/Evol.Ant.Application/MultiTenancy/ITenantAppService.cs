using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Evol.Ant.MultiTenancy.Dto;

namespace Evol.Ant.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

