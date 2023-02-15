using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace dotnet_core_oidc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration Configuration;

        public HomeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [Authorize]
        public IActionResult Index()
        {
            var configurationDump = ((IConfigurationRoot)Configuration).GetDebugView();
            ViewBag.ConfigurationDump = configurationDump;
            return View();
        }
    }
}
