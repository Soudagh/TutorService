using MediatR;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Events.Queries;

public class GetUserQuery : IRequest<UserResponse>
{
    public string UserId { get; set; } = null!;
}