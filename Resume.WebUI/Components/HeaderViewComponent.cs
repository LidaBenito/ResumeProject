using Microsoft.AspNetCore.Mvc;

namespace Resume.WebUI.Components
{
    public class HeaderViewComponent : ViewComponent
    {
        #region fields

        #endregion
        #region constructors
        #endregion
        #region methods
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("Header");
        }
        #endregion
    }
}
