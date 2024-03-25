namespace TutorService.Application.Models.Entities;

public class Student
{
    public Guid StudentId { get; set; }

    public Guid StudentUserId { get; set; }

    public Guid TutorId { get; set; }

    public Guid ThemeId { get; set; }

    public Student(
        Guid studentId,
        Guid studentUserId,
        Guid tutorId,
        Guid themeId)
    {
        StudentId = studentId;
        StudentUserId = studentUserId;
        TutorId = tutorId;
        ThemeId = themeId;
    }
}