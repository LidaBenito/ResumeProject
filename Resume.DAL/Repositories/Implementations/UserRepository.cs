using Resume.DAL.Context;
using Resume.DAL.Model;
using Resume.DAL.Repositories.Interfaces;

namespace Resume.DAL.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly ResumeContext _context;

        public UserRepository(ResumeContext context)
        {
            _context = context;
        }

        public async Task InsertUser(User user)
        {
            await _context.Users.AddAsync(user);
            
        }

        public async Task SaveUser()
        {
            await _context.SaveChangesAsync();
        }
    }
}
