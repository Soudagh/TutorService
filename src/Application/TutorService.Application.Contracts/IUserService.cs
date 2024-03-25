using TutorService.Application.Models;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Contracts;

public interface IUserService
{
    Task<bool> CreateUserAsync(UserModel userModel);

    Task<UserResponse> GetUserAsync(string userId);

    Task<bool> UpdateUserAsync(string userId, UserModel userModel);

    Task<bool> DeleteUserAsync(string userId);
}