using MediatR;
using TutorService.Application.Models.Dtos;

namespace TutorService.Application.Events.Queries;

public class GetThemeQuery : IRequest<ThemeResponse>
{
    public string ThemeId { get; set; } = null!;
}