namespace TutorService.Application.Models;

public class StudentModel
{
    public int StudentId { get; set; }

    public int StudentUserId { get; set; }

    public int TutorId { get; set; }

    public int ThemeId { get; set; }

    public List<ExerciseModel> CompletedTasks { get; set; }

    public List<ExerciseModel> SuggestedTasks { get; set; }

    public StudentModel(int studentId, int studentUserId, int tutorId, int themeId,
        List<ExerciseModel> completedTasks, List<ExerciseModel> suggestedTasks)
    {
        StudentId = studentId;
        StudentUserId = studentUserId;
        TutorId = tutorId;
        ThemeId = themeId;
        CompletedTasks = completedTasks;
        SuggestedTasks = suggestedTasks;
    }
}