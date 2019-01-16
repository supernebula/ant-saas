using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace Evol.Ant.Web.Views
{
    public abstract class AntRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AntRazorPage()
        {
            LocalizationSourceName = AntConsts.LocalizationSourceName;
        }
    }
}
