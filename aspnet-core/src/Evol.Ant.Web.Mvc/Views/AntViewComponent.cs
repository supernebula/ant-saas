using Abp.AspNetCore.Mvc.ViewComponents;

namespace Evol.Ant.Web.Views
{
    public abstract class AntViewComponent : AbpViewComponent
    {
        protected AntViewComponent()
        {
            LocalizationSourceName = AntConsts.LocalizationSourceName;
        }
    }
}
