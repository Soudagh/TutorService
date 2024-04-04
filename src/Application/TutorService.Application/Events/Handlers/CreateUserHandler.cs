using MediatR;
using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Events.Commands;
using TutorService.Application.Models;
using TutorService.Application.Models.Models;

namespace TutorService.Application.Events.Handlers;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, bool>
{
    private readonly IUserRepository _userRepository;

    public CreateUserHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var userModel = new UserModel
        {
            UserId = Guid.NewGuid(),
            FullName = request.UserCreateRequest.FullName,
            Mail = request.UserCreateRequest.Mail,
            Phone = request.UserCreateRequest.Phone,
            Login = request.UserCreateRequest.Login,
            PasswordHashed = request.UserCreateRequest.PasswordHashed,
            Avatar = request.UserCreateRequest.Avatar,
            Role = (Roles)Enum.Parse(typeof(Roles), request.UserCreateRequest.Role),
        };

        return _userRepository.CreateUser(userModel);
    }
}