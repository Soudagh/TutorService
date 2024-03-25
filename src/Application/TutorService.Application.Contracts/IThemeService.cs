using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Requests;

namespace TutorService.Application.Contracts;

public interface IThemeService
{
    Task<bool> CreateThemeAsync(ThemeCreateRequest request);

    Task<ThemeResponse> GetThemeAsync(string id);

    Task<bool> UpdateThemeAsync(string id, ThemeUpdateRequest request);

    Task<bool> DeleteThemeAsync(string id);
}