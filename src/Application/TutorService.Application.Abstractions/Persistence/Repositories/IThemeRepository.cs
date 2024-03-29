using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Models;

namespace TutorService.Application.Abstractions.Persistence.Repositories;

public interface IThemeRepository
{
    Task<bool> CreateTheme(ThemeModel themeModel);

    Task<ThemeResponse> GetTheme(string themeId);

    Task<bool> UpdateTheme(string themeId, ThemeModel themeModel);

    Task<bool> DeleteTheme(string themeId);
}