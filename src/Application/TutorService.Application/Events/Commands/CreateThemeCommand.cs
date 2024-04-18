using MediatR;
using TutorService.Application.Models.Requests;

namespace TutorService.Application.Events.Commands;

public class CreateThemeCommand : IRequest<bool>
{
    public ThemeCreateRequest ThemeCreateRequest { get; set; } = null!;
}