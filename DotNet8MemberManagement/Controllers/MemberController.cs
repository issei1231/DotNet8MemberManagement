using Microsoft.AspNetCore.Mvc;

namespace DotNet8MemberManagement.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Search()
        {
            return View();
        }
    }
}
