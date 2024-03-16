using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Abstractions.Persistence.Repositories;

public interface IUserRepository
{
    Task<bool> CreateUser(UserCreateRequest request);

    Task<UserResponse> GetUser(string userId);

    Task<bool> UpdateUser(string userId, UserUpdateRequest request);

    Task<bool> DeleteUser(string userId);
}