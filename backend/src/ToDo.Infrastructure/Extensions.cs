using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.SqlServer;
using ToDo.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ToDo.Infrastructure;

public static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration){

        services.AddDbContext<ToDoContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            
        return services;
    }
}
