﻿using Microsoft.AspNetCore.Mvc;

namespace Resume.WebUI.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        #region Actions
        public IActionResult Index()
        {
            return View();
        }
        #endregion
    }
}
