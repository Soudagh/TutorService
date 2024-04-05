using TutorService.Presentation.Http.Middlewares;

namespace TutorService.Presentation.Http.Extensions;

public static class MvcBuilderExtensions
{
    public static IMvcBuilder AddPresentationHttp(this IMvcBuilder builder)
    {
        builder.Services.AddSingleton<RequestLoggerMiddleware>();
        builder.Services.AddSingleton<ExceptionHandlerMiddleware>();

        return builder.AddApplicationPart(typeof(IAssemblyMarker).Assembly);
    }
}