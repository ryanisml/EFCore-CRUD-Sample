using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CRUDSample.Controllers
{
    [AllowAnonymous]
    public class SignController : Controller
    {
        public IActionResult Index()
        {
            if(User.Identity != null)
            {
                if (User.Identity.IsAuthenticated)
                {
                    return RedirectToAction("index", "home");
                }
            }
            return View();
        }
    }
}
