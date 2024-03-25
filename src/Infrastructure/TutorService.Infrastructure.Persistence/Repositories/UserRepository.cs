using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Models.Entities;
using TutorService.Application.Models.Models;
using TutorService.Application.Models.Responses;
using TutorService.Infrastructure.Persistence.Contexts;
using TutorService.Infrastructure.Persistence.Mapping;

namespace TutorService.Infrastructure.Persistence.Repositories;

public class UserRepository(ApplicationDbContext context) : IUserRepository
{
    public async Task<bool> CreateUser(UserModel userModel)
    {
        try
        {
            var user = UserMapper.ModelToEntity(userModel);
            context.Add(entity: user);
            await context.SaveChangesAsync();

            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public async Task<UserResponse> GetUser(string userId)
    {
        try
        {
            User? user = await context.Users.FindAsync(new Guid(userId));
            if (user == null)
            {
                return null!;
            }

            // User user = UserMapper.ModelToEntity(userModel);
            return new UserResponse(
                user.UserId.ToString(),
                user.FullName,
                user.Phone,
                user.Mail,
                user.Avatar,
                user.Login,
                user.Role);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null!;
        }
    }

    public async Task<bool> UpdateUser(string userId, UserModel userModel)
    {
        try
        {
            User? user = await context.Users.FindAsync(new Guid(userId));
            if (user == null)
            {
                return false;
            }

            // User user = UserMapper.ModelToEntity(foundUserModel);
            user.FullName = userModel.FullName;
            user.Phone = userModel.Phone;
            user.Mail = userModel.Mail;
            user.Avatar = userModel.Avatar;
            user.Login = userModel.Login;
            user.PasswordHashed = userModel.PasswordHashed;
            user.Role = userModel.Role;

            await context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> DeleteUser(string userId)
    {
        try
        {
            User? user = await context.Users.FindAsync(new Guid(userId));
            if (user == null)
            {
                return false;
            }

            context.Users.Remove(user);
            await context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}