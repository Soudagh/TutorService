namespace TutorService.Application.Models;

public class StudentInTask
{
    private string _studentThemeId;
    private string _studentId;
    private string _tutorId;
    private string _themeId;
    private List<ExerciseModel> _completedTasks;
    private List<ExerciseModel> _suggestedTasks;

    public StudentInTask(string studentThemeId, string studentId, string tutorId, string themeId,
        List<ExerciseModel> completedTasks, List<ExerciseModel> suggestedTasks)
    {
        _studentThemeId = studentThemeId;
        _studentId = studentId;
        _tutorId = tutorId;
        _themeId = themeId;
        _completedTasks = completedTasks;
        _suggestedTasks = suggestedTasks;
    }
}