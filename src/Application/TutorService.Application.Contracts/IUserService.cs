using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Contracts;

public interface IUserService
{
    Task<bool> CreateUserAsync(UserCreateRequest request);

    Task<UserResponse> GetUserAsync(string userId);

    Task<bool> UpdateUserAsync(string userId, UserUpdateRequest request);

    Task<bool> DeleteUserAsync(string userId);
}