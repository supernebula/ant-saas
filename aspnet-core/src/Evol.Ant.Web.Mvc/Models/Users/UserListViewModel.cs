using System.Collections.Generic;
using Evol.Ant.Roles.Dto;
using Evol.Ant.Users.Dto;

namespace Evol.Ant.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
