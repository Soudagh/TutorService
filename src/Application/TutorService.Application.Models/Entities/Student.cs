namespace TutorService.Application.Models.Entities;

public class Student
{
    public Guid StudentId { get; set; }

    public Guid StudentUserId { get; set; }

    public Guid TutorId { get; set; }

    public Guid ThemeId { get; set; }

    public User StudentUser { get; set; } = null!;

    public User Tutor { get; set; } = null!;

    public Theme Theme { get; set; } = null!;
}