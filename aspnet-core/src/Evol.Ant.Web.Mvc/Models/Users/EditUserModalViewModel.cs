using System.Collections.Generic;
using System.Linq;
using Evol.Ant.Roles.Dto;
using Evol.Ant.Users.Dto;

namespace Evol.Ant.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
