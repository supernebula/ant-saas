using System.Collections.Generic;
using Evol.Ant.Roles.Dto;

namespace Evol.Ant.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
