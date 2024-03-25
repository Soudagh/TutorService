namespace TutorService.Application.Models.Entities;

public class Exercise
{
    public Guid TaskId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int Difficulty { get; set; }

    public Exercise(Guid taskId, string name, string description, int difficulty)
    {
        TaskId = taskId;
        Name = name;
        Description = description;
        Difficulty = difficulty;
    }
}