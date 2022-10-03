using EventPlanner.Core.Services;
using EventPlanner.Services.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Services
{
    public static class EventPlannerServicesServiceCollectionExtensions
    {
        public static void AddEventPlannerServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IOrganizerService, OrganizerService>();
        }
    }
}
