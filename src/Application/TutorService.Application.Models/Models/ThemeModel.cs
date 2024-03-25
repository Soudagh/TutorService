namespace TutorService.Application.Models;

public class ThemeModel
{
    public Guid ThemeId { get; set; }

    public string Title { get; set; }

    public int Difficulty { get; set; }

    public ThemeModel(Guid themeId, string title, int difficulty)
    {
        ThemeId = themeId;
        Title = title;
        Difficulty = difficulty;
    }
}