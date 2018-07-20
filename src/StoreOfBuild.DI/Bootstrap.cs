using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using StoreOfBuild.Data;
using StoreOfBuild.Data.Contexts;
using StroreOfBuild.Domain;
using StroreOfBuild.Domain.Products;
using StoreOfBuild.Data.Repositories;

namespace StoreOfBuild.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string conection)
        {
            //serviços de injeção de dependência
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(conection));
            services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
            services.AddSingleton(typeof(CategoryStorer));
        }
    }
}
