namespace TutorService.Application.Models;

public class TaskModel
{
    public int TaskId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int Difficulty { get; set; }

    public TaskModel(int taskId, string name, string description, int difficulty)
    {
        TaskId = taskId;
        Name = name;
        Description = description;
        Difficulty = difficulty;
    }
}