using Resume.Business.Services.Implementation;
using Resume.Business.Services.Interface;
using Resume.DAL.Repositories.Implementations;
using Resume.DAL.Repositories.Interfaces;

namespace Resume.WebUI.Configuration
{
    public static class DiContainer
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            #region Repositories
            services.AddScoped<IUserRepository, UserRepository>();
            #endregion

            #region Services
            services.AddScoped<IUserService,UserService>();
            #endregion
        }
    }
}
