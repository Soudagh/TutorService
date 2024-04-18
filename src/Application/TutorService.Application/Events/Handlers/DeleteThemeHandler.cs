using MediatR;
using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Events.Commands;

namespace TutorService.Application.Events.Handlers;

public class DeleteThemeHandler : IRequestHandler<DeleteThemeCommand, bool>
{
    private readonly IThemeRepository _themeRepository;

    public DeleteThemeHandler(IThemeRepository themeRepository)
    {
        _themeRepository = themeRepository;
    }

    public Task<bool> Handle(DeleteThemeCommand request, CancellationToken cancellationToken)
    {
        return _themeRepository.DeleteTheme(request.ThemeId);
    }
}