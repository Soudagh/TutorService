using Microsoft.Extensions.DependencyInjection;
using TutorService.Application.Contracts;
using TutorService.Application.Services;

namespace TutorService.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddScoped<ITaskService, TaskService>();
        collection.AddScoped<IUserService, UserService>();

        return collection;
    }
}