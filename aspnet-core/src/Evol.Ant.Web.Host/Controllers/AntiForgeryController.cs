using Microsoft.AspNetCore.Antiforgery;
using Evol.Ant.Controllers;

namespace Evol.Ant.Web.Host.Controllers
{
    public class AntiForgeryController : AntControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
