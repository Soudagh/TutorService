using TutorService.Application.Models;

namespace TutorService.Application.Contracts;

public interface IExerciseModel
{
    ExerciseModel Create(string name, string description, int difficulty);

    ExerciseModel Get(int exerciseId);

    bool Update(ExerciseModel newExercise);

    bool Delete(int exerciseId);
}