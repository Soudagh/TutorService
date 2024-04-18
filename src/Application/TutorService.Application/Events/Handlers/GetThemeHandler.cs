using MediatR;
using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Events.Queries;
using TutorService.Application.Models.Dtos;

namespace TutorService.Application.Events.Handlers;

public class GetThemeHandler : IRequestHandler<GetThemeQuery, ThemeResponse>
{
    private readonly IThemeRepository _themeRepository;

    public GetThemeHandler(IThemeRepository themeRepository)
    {
        _themeRepository = themeRepository;
    }

    public async Task<ThemeResponse> Handle(GetThemeQuery request, CancellationToken cancellationToken)
    {
        ThemeResponse theme = await _themeRepository.GetTheme(request.ThemeId);
        return new ThemeResponse(theme.ThemeId, theme.Title, theme.Difficulty);
    }
}