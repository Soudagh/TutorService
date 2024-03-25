namespace TutorService.Application.Models.Entities;

public class Theme
{
    public Guid ThemeId { get; set; }

    public string Title { get; set; }

    public int Difficulty { get; set; }

    public Theme(Guid themeId, string title, int difficulty)
    {
        ThemeId = themeId;
        Title = title;
        Difficulty = difficulty;
    }
}