using AspCoreDemoProject.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreDemoProject.Services
{
    public static class CustomServices
    {
        public static void AddCustomService(this IServiceCollection services)
        {
            services.AddSingleton<IStudentRepository, StudentRepository>();
        }
    }
}
