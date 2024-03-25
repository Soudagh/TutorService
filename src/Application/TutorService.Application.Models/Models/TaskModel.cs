using System.ComponentModel.DataAnnotations.Schema;

namespace TutorService.Application.Models.Models;

public class TaskModel
{
    public Guid TaskId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int Difficulty { get; set; }

    public TaskModel(Guid taskId, string name, string description, int difficulty)
    {
        TaskId = taskId;
        Name = name;
        Description = description;
        Difficulty = difficulty;
    }
}