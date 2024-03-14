using TutorService.Application.Models;

namespace TutorService.Application.Contracts;

public interface IExerciseModel
{
    ExerciseModel CreateExercise(string name, string description, int difficulty);

    ExerciseModel GetExercise(int exerciseId);

    bool UpdateExercise(ExerciseModel newExercise);

    bool DeleteExercise(int exerciseId);
}