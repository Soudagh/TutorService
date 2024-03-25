using TutorService.Application.Models.Models;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Abstractions.Persistence.Repositories;

public interface IUserRepository
{
    Task<bool> CreateUser(UserModel userModel);

    Task<UserResponse> GetUser(string userId);

    Task<bool> UpdateUser(string userId, UserModel userModel);

    Task<bool> DeleteUser(string userId);
}