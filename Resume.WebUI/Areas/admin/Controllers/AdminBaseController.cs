using Microsoft.AspNetCore.Mvc;

namespace Resume.WebUI.Areas.admin.Controllers
{
    [Area(areaName:"Admin")]
    public class AdminBaseController : Controller
    {
        protected string SuccessMsg = "Success Message";
        protected string ErrorMsg = "Error Message";
    }
}
