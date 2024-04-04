using MediatR;
using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Events.Commands;
using TutorService.Application.Models.Models;

namespace TutorService.Application.Events.Handlers;

public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, bool>
{
    private readonly IUserRepository _userRepository;

    public UpdateUserHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var userModel = new UserModel
        {
            UserId = Guid.Empty,
            FullName = request.UserUpdateRequest.FullName,
            Login = request.UserUpdateRequest.Login,
            Avatar = request.UserUpdateRequest.Avatar,
            Mail = request.UserUpdateRequest.Mail,
            PasswordHashed = request.UserUpdateRequest.PasswordHashed,
            Phone = request.UserUpdateRequest.Phone,
            Role = request.UserUpdateRequest.Role,
        };
        return _userRepository.UpdateUser(request.UserId, userModel);
    }
}