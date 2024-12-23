using Resume.Business.Services.Interface;
using Resume.DAL.Model;
using Resume.DAL.Repositories.Interfaces;
using Resume.DAL.ViewModels;

namespace Resume.Business.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<CreateUserResult> CreateUser(CreateUserViewModel model)
        {
            User user = new()
            {
                CreateDate = DateTime.Now,
                Mobile = model.Mobile,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email.Trim().ToLower(),
                Password = model.Password,
                IsActive = model.IsActive
            };
            await _userRepository.InsertUser(user);
            await _userRepository.SaveUser();
            return CreateUserResult.Success;
        }

        public async Task<EditUserResult> EditUser(EditUserViewModel model)
        {
            var user = await _userRepository.GetUserById(model.Id);
            var EmailStr = model.Email.ToLower().Trim();
            if (user == null)
                return EditUserResult.UserNotFound;
            if (await _userRepository.DuplicatedEmail(user.Id, EmailStr))
                return EditUserResult.Emailduplicated;
            if (await _userRepository.DuplicatedMobile(user.Id, model.Mobile))
                return EditUserResult.MobileDuplicated;
            user.IsActive= model.IsActive;
            user.FirstName=model.FirstName;
            user.LastName=model.LastName;
            user.Email = model.Email;
            user.Mobile = model.Mobile;
            _userRepository.UpdateUser(user);
            await _userRepository.SaveUser();
            return EditUserResult.Success;
        }

        public async Task<EditUserViewModel> EditUserById(int id)
        {
            User user = await _userRepository.GetUserById(id);
            if (user == null)
                return null;
            return new EditUserViewModel()
            {
                Id = user.Id,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Mobile = user.Mobile,
                IsActive = user.IsActive
            };
        }
    }
}
