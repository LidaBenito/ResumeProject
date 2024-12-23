using Microsoft.EntityFrameworkCore;
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

        public async Task<bool> DuplicatedEmail(int id, string email) => await _context.Users.AnyAsync(user =>
        user.Email == email && user.Id != id);

        public async Task<bool> DuplicatedMobile(int id, string mobile) => await _context.Users.AnyAsync(user
         => user.Mobile == mobile && user.Id != id);

        public async Task<User> GetUserById(int id) => await _context.Users.FirstOrDefaultAsync(user => user.Id == id);

        public async Task InsertUser(User user)
        {
            await _context.Users.AddAsync(user);
        
        }

        public async Task SaveUser()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
        }
    }
}
