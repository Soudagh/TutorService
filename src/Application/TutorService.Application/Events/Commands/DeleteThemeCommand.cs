using MediatR;

namespace TutorService.Application.Events.Commands;

public class DeleteThemeCommand : IRequest<bool>
{
    public string ThemeId { get; set; } = null!;
}