using MediatR;
using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Events.Queries;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Events.Handlers;

public class GetUserHandler : IRequestHandler<GetUserQuery, UserResponse>
{
    private readonly IUserRepository _userRepository;

    public GetUserHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserResponse> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        UserResponse user = await _userRepository.GetUser(request.UserId);
        return new UserResponse(user.UserId, user.FullName, user.Phone, user.Mail, user.Avatar, user.Login, user.Role);
    }
}