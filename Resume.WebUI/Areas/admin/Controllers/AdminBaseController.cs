using Microsoft.AspNetCore.Mvc;

namespace Resume.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBaseController : Controller
    {
        protected string SuccessMsg = "Success Message";
        protected string ErrorMsg = "Error Message";
    }
}
