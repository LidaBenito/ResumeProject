using Microsoft.AspNetCore.Mvc;
using Resume.Business.Services.Interface;
using Resume.DAL.ViewModels;

namespace Resume.WebUI.Areas.Admin.Controllers
{
    public class UserController : Controller

    {
        #region Fields
        private readonly IUserService _userService;


        #endregion

        #region Constructors

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        #endregion

        #region Actions
        public async Task<IActionResult> List()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return View();
        }
        public async Task<IActionResult> Update(int id)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(EditUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return View();
        }

        #endregion

    }
}
