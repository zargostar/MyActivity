using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Activities.Queries.GetActivities;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationServiceDI
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services){
                 //services.AddMediatR(cfg =>
                 //cfg.RegisterServicesFromAssembly(typeof(GetActivitiesQuery).Assembly));
                 //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
                 
                 return services;
        } 
    }
}