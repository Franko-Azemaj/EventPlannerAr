using EventPlaner.EFCore.Contexts;
using EventPlanner.Core.Repositories;
using EventPlanner.Core.Services;
using EventPlanner.EFCore.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Services
{
    public static class EventPlannerEFCoreServiceCollectionExtensions
    {
        public static void AddEventPlannerRepositories(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IOrganizerRepository, OrganizerRepository>();
        }
    }
}
