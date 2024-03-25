using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Contracts;
using TutorService.Application.Models.Models;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<bool> CreateUserAsync(UserModel userModel)
    {
        return await _userRepository.CreateUser(userModel);
    }

    public async Task<UserResponse> GetUserAsync(string userId)
    {
        UserResponse user = await _userRepository.GetUser(userId);
        return new UserResponse(user.UserId, user.FullName, user.Phone, user.Mail, user.Avatar, user.Login, user.Role);
    }

    public async Task<bool> UpdateUserAsync(string userId, UserModel userModel)
    {
        return await _userRepository.UpdateUser(userId, userModel);
    }

    public async Task<bool> DeleteUserAsync(string userId)
    {
        return await _userRepository.DeleteUser(userId);
    }
}