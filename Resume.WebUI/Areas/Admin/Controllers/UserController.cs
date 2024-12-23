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
            
                return View(model);
            var result = await _userService.CreateUser(model);
            #region CheckResult
            switch (result)
            {
                case CreateUserResult.Success:
                    break;
                case CreateUserResult.Error:
                    break;
            }
            return View();
        }
        public async Task<IActionResult> Update(int id)
        {
            EditUserViewModel user = await _userService.EditUserById(id);
            if (user == null)
                return NotFound();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(EditUserViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var result = await _userService.EditUser(model);
            #region checkResult
            switch (result)
            {
                case EditUserResult.Success:
                    break;
                case EditUserResult.Error:
                    break;
                case EditUserResult.Emailduplicated:
                    break;
                case EditUserResult.UserNotFound:
                    break;
                case EditUserResult.MobileDuplicated:
                    break;
            }
            #endregion
            return View();
        }

        #endregion

    }
}
