using TutorService.Application.Models;

namespace TutorService.Application.Contracts;

public interface IThemeService
{
    ThemeModel CreateTheme(string title, int difficulty);

    ThemeModel GetTheme(int themeId);

    bool UpdateTheme(ThemeModel newTheme);

    bool DeleteTheme(int themeId);
}