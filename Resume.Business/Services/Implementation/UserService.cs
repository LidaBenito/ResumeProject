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
                Mobile=model.Mobile,
                FirstName=model.FirstName,
                LastName=model.LastName,
                Email=model.Email,
                Password=model.Password,
                IsActive=model.IsActive
            };
            await _userRepository.InsertUser(user);
            await _userRepository.SaveUser();
            return CreateUserResult.Success;
        }
    }
}
