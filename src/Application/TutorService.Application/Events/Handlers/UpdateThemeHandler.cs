using MediatR;
using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Events.Commands;
using TutorService.Application.Models.Models;

namespace TutorService.Application.Events.Handlers;

public class UpdateThemeHandler : IRequestHandler<UpdateThemeCommand, bool>
{
    private readonly IThemeRepository _themeRepository;

    public UpdateThemeHandler(IThemeRepository themeRepository)
    {
        _themeRepository = themeRepository;
    }

    public Task<bool> Handle(UpdateThemeCommand request, CancellationToken cancellationToken)
    {
        var themeModel = new ThemeModel
        {
            ThemeId = Guid.Empty,
            Title = request.ThemeUpdateRequest.Title,
            Difficulty = request.ThemeUpdateRequest.Difficulty,
        };
        return _themeRepository.UpdateTheme(request.ThemeId, themeModel);
    }
}