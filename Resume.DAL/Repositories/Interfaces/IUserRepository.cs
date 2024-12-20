using Resume.DAL.Model;

namespace Resume.DAL.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task InsertUser(User user);
        Task SaveUser();
    }
}
