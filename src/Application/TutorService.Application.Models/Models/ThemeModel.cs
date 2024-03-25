namespace TutorService.Application.Models.Models;

public class ThemeModel
{
    public Guid ThemeId { get; set; }

    public string Title { get; set; } = null!;

    public int Difficulty { get; set; }
}