using TutorService.Application.Models;
using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Entities;
using TutorService.Application.Models.Models;

namespace TutorService.Infrastructure.Persistence.Mapping;

public class UserMapper
{
    public static User ModelToEntity(UserModel userModel)
    {
        var user = new User(
            userId: userModel.UserId,
            fullName: userModel.FullName,
            phone: userModel.Phone,
            mail: userModel.Mail,
            avatar: userModel.Avatar,
            login: userModel.Login,
            passwordHashed: userModel.PasswordHashed,
            role: userModel.Role);

        return user;
    }

    public static UserModel EntityToModel(User user)
    {
        var userModel = new UserModel
        {
            UserId = user.UserId,
            FullName = user.FullName,
            Phone = user.Phone,
            Mail = user.Mail,
            Avatar = user.Avatar,
            Login = user.Login,
            PasswordHashed = user.PasswordHashed,
            Role = user.Role,
        };
        return userModel;
    }

    public static UserModel UserCreateToModel(UserCreateRequest request)
    {
        var userModel = new UserModel
        {
            UserId = Guid.NewGuid(),
            FullName = request.FullName,
            Mail = request.Mail,
            Phone = request.Phone,
            Login = request.Login,
            PasswordHashed = request.PasswordHashed,
            Avatar = request.Avatar,
            Role = (Roles)Enum.Parse(typeof(Roles), request.Role),
        };

        return userModel;
    }

    public static UserModel UserUpdateToModel(UserUpdateRequest request)
    {
        var userModel = new UserModel
        {
            UserId = Guid.Empty,
            FullName = request.FullName,
            Mail = request.Mail,
            Phone = request.Phone,
            Login = request.Login,
            PasswordHashed = request.PasswordHashed,
            Avatar = request.Avatar,
            Role = request.Role,
        };
        return userModel;
    }
}
