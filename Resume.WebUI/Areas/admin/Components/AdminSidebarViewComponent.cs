﻿using Microsoft.AspNetCore.Mvc;

namespace Resume.WebUI.Areas.Admin.Components
{
    public class AdminSidebarViewComponent : ViewComponent
    {
        #region Methods
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("AdminSidebar");
        }
        #endregion
    }
}
