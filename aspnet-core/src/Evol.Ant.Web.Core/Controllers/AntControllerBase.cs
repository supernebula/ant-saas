using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Evol.Ant.Controllers
{
    public abstract class AntControllerBase: AbpController
    {
        protected AntControllerBase()
        {
            LocalizationSourceName = AntConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
