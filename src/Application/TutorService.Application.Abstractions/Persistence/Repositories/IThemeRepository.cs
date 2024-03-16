using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Abstractions.Persistence.Repositories;

public interface IThemeRepository
{
    Task<bool> CreateTheme(ThemeCreateRequest request);

    Task<ThemeResponse> GetTheme(string id);

    Task<bool> UpdateTheme(string id, ThemeUpdateRequest request);

    Task<bool> DeleteTheme(string id);
}