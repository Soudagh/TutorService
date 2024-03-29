using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Models;

namespace TutorService.Application.Contracts;

public interface IThemeService
{
    Task<bool> CreateThemeAsync(ThemeModel themeModel);

    Task<ThemeResponse> GetThemeAsync(string themeId);

    Task<bool> UpdateThemeAsync(string themeId, ThemeModel themeModel);

    Task<bool> DeleteThemeAsync(string themeId);
}