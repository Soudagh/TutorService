using TutorService.Application.Models;

namespace TutorService.Application.Contracts;

public interface IUserService
{
    UserModel RegisterUser(
        string fullName,
        string phone,
        string mail,
        string avatar,
        string login,
        string hashedPassword,
        RoleEnum role);

    UserModel LoginUser(string login, string password);

    UserModel GetUser(int userId);

    bool UpdateUser(UserModel newUser);

    bool DeleteUser(int userId);
}