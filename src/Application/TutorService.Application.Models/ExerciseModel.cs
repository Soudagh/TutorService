namespace TutorService.Application.Models;

public class ExerciseModel
{
    public int ExerciseId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int Difficulty { get; set; }

    public ExerciseModel(int exerciseId, string name, string description, int difficulty)
    {
        ExerciseId = exerciseId;
        Name = name;
        Description = description;
        Difficulty = difficulty;
    }
}