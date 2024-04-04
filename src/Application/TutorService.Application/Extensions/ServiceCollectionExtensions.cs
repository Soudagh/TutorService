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
        collection.AddScoped<IThemeService, ThemeService>();
        collection.AddScoped<ITaskThemeService, TaskThemeService>();
        collection.AddScoped<IStudentService, StudentService>();
        collection.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(ServiceCollectionExtensions).Assembly));

        return collection;
    }
}