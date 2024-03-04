namespace TutorService.Application.Models;

public class ExerciseModel
{
    private string _taskID;
    private string _name;
    private string _description;
    private string _difficulty;

    public ExerciseModel(string taskId, string name, string description, string difficulty)
    {
        _taskID = taskId;
        _name = name;
        _description = description;
        _difficulty = difficulty;
    }
}