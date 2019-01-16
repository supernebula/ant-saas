using System.Collections.Generic;
using Evol.Ant.Roles.Dto;

namespace Evol.Ant.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}