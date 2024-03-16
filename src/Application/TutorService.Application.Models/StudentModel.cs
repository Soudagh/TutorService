using System.Collections.ObjectModel;

namespace TutorService.Application.Models;

public class StudentModel
{
    public int StudentId { get; set; }

    public int StudentUserId { get; set; }

    public int TutorId { get; set; }

    public int ThemeId { get; set; }

    public Collection<TaskModel> CompletedTasks { get; }

    public Collection<TaskModel> SuggestedTasks { get; }

    public StudentModel(
        int studentId,
        int studentUserId,
        int tutorId,
        int themeId,
        Collection<TaskModel> completedTasks,
        Collection<TaskModel> suggestedTasks)
    {
        StudentId = studentId;
        StudentUserId = studentUserId;
        TutorId = tutorId;
        ThemeId = themeId;
        CompletedTasks = completedTasks;
        SuggestedTasks = suggestedTasks;
    }
}