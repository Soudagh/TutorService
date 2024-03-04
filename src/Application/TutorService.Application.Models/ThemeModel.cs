using System.Reflection;

namespace TutorService.Application.Models;

public class ThemeModel
{
    private string _themeID;
    private string _title;
    private string _difficulty;

    public ThemeModel(string theme, string title, string difficulty)
    {
        _themeID = theme;
        _title = title;
        _difficulty = difficulty;
    }
}