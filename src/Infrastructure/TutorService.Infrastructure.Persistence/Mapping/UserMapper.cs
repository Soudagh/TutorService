using TutorService.Application.Models;
using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Entities;

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
        var userModel = new UserModel(
            userId: user.UserId,
            fullName: user.FullName,
            phone: user.Phone,
            mail: user.Mail,
            avatar: user.Avatar,
            login: user.Login,
            passwordHashed: user.PasswordHashed,
            role: user.Role);
        return userModel;
    }

    public static UserModel UserCreateToModel(UserCreateRequest request)
    {
        var userModel = new UserModel(
                userId: Guid.NewGuid(),
                fullName: request.FullName,
                mail: request.Mail,
                phone: request.Phone,
                login: request.Login,
                passwordHashed: request.PasswordHashed,
                avatar: request.Avatar,
                role: (Roles)Enum.Parse(typeof(Roles), request.Role));
        return userModel;
    }

    public static UserModel UserUpdateToModel(UserUpdateRequest request)
    {
        var userModel = new UserModel(
            userId: Guid.Empty,
            fullName: request.FullName,
            mail: request.Mail,
            phone: request.Phone,
            login: request.Login,
            passwordHashed: request.PasswordHashed,
            avatar: request.Avatar,
            role: request.Role);
        return userModel;
    }
}