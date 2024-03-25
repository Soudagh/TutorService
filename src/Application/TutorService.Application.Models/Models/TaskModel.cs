namespace TutorService.Application.Models.Models;

public class TaskModel
{
    public Guid TaskId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Difficulty { get; set; }
}