using Resume.DAL.ViewModels;

namespace Resume.Business.Services.Interface
{
    public interface IUserService
    {
        Task<CreateUserResult> CreateUser(CreateUserViewModel model);
        Task<EditUserViewModel> EditUserById(int id);
        Task<EditUserResult> EditUser(EditUserViewModel model);
    
    }
}
