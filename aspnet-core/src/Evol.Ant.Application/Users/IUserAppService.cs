using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Evol.Ant.Roles.Dto;
using Evol.Ant.Users.Dto;

namespace Evol.Ant.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
