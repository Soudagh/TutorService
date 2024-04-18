using MediatR;
using TutorService.Application.Models.Dtos;

namespace TutorService.Application.Events.Commands;

public class UpdateThemeCommand : IRequest<bool>
{
    public string ThemeId { get; set; } = null!;

    public ThemeUpdateRequest ThemeUpdateRequest { get; set; } = null!;
}
