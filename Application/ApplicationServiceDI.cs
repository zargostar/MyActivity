using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationServiceDI
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services){
                 return services;
        } 
    }
}