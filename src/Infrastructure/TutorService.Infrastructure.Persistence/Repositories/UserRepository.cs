using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Models;
using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;
using TutorService.Infrastructure.Persistence.Contexts;

namespace TutorService.Infrastructure.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CreateUser(UserCreateRequest request)
    {
        try
        {
            var newUser = new UserModel(
                userId: Guid.Empty,
                fullName: request.FullName,
                phone: request.Phone,
                mail: request.Phone,
                avatar: request.Avatar,
                login: request.Login,
                passwordHashed: request.PasswordHashed,
                role: request.Role);

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<UserResponse> GetUser(string userId)
    {
        try
        {
            UserModel? user = await _context.Users.FindAsync(userId);
            if (user == null)
            {
                return null!;
            }

            return new UserResponse(
                user.UserId.ToString(),
                user.FullName,
                user.Phone,
                user.Mail,
                user.Avatar,
                user.Login,
                user.Role);
        }
        catch (Exception)
        {
            return null!;
        }
    }

    public async Task<bool> UpdateUser(string userId, UserUpdateRequest request)
    {
        try
        {
            UserModel? user = await _context.Users.FindAsync(userId);
            if (user == null)
            {
                return false;
            }

            user.FullName = request.FullName;
            user.Phone = request.Phone;
            user.Mail = request.Mail;
            user.Avatar = request.Avatar;
            user.Login = request.Login;
            user.PasswordHashed = request.PasswordHashed;
            user.Role = request.Role;

            await _context.SaveChangesAsync();
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
            UserModel? user = await _context.Users.FindAsync(userId);
            if (user == null)
            {
                return false;
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}