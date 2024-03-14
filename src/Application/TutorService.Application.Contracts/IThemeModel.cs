using TutorService.Application.Models;

namespace TutorService.Application.Contracts;

public interface IThemeModel
{
    ThemeModel Create(string title, int difficulty);

    ThemeModel Get(int themeId);

    bool Update(ThemeModel newTheme);

    bool Delete(int themeId);
}