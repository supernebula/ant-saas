using Abp.Authorization;
using Evol.Ant.Authorization.Roles;
using Evol.Ant.Authorization.Users;

namespace Evol.Ant.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
