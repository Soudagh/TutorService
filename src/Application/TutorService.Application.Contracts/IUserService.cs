using TutorService.Application.Models;

namespace TutorService.Application.Contracts;

public interface IUserService
{
    UserModel Register(string fullName, string phone, string mail, string avatar, string login, string hashedPassword,
        RoleEnum role);

    UserModel Login(string login, string password);
    
    UserModel Get(int userId);

    bool Update(UserModel newUser);

    bool Delete(int userId);
}