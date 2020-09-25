using Infrastructure.Identity;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        // Extension method to add dependency injection to Startup
        public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration
            configuration)
        {

            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseInMemoryDatabase("LaundryDb"));
            }
            else
            {
                services.AddDbContext<ApplicationDbContext>(options =>
          options.UseSqlServer(
              configuration.GetConnectionString("DefaultConnection")));

            }

            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddIdentityServer()
                .AddApiAuthorization<ApplicationUser, ApplicationDbContext>();

            services.AddAuthentication()
                .AddIdentityServerJwt();

            return services;
        }
    }
}
