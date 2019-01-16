using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Evol.Ant.Controllers;

namespace Evol.Ant.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : AntControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
