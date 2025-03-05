using Microsoft.Extensions.DependencyInjection;
using Convey;
using Convey.CQRS.Commands;
using Convey.CQRS.Queries;
using AutoMapper;

namespace ToDo.Application;

public static class Extensions 
{
    public static IServiceProvider AddApplication(this IServiceCollection services){

        var builder = services.AddConvey()
            .AddQueryHandlers()
            .AddInMemoryQueryDispatcher()
            .AddCommandHandlers()
            .AddInMemoryCommandDispatcher();

        return builder.Build(); 
    }
}
