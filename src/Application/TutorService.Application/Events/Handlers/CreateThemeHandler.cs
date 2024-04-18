using MediatR;
using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Events.Commands;
using TutorService.Application.Models.Models;

namespace TutorService.Application.Events.Handlers;

public class CreateThemeHandler : IRequestHandler<CreateThemeCommand, bool>
{
    private readonly IThemeRepository _themeRepository;

    public CreateThemeHandler(IThemeRepository themeRepository)
    {
        _themeRepository = themeRepository;
    }

    public Task<bool> Handle(CreateThemeCommand request, CancellationToken cancellationToken)
    {
        var themeModel = new ThemeModel
        {
            ThemeId = Guid.NewGuid(),
            Title = request.ThemeCreateRequest.Title,
            Difficulty = request.ThemeCreateRequest.Difficulty,
        };

        return _themeRepository.CreateTheme(themeModel);
    }
}