using Resume.DAL.Model;

namespace Resume.DAL.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task InsertUser(User user);
        Task<User> GetUserById(int id);
        Task<bool> DuplicatedEmail(int id  ,string email);
        Task<bool> DuplicatedMobile(int id  ,string mobile);
        void UpdateUser(User user);

        Task SaveUser();
    }
}
