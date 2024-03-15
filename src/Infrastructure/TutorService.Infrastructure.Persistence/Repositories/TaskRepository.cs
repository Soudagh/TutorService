using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Models;
using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;
using TutorService.Infrastructure.Persistence.Contexts;

namespace TutorService.Infrastructure.Persistence.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly ApplicationDbContext _context;

    public TaskRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CreateTask(TaskCreateRequest request)
    {
        try
        {
            var newTask = new ExerciseModel(
                exerciseId: 0,
                name: request.Name,
                description: request.Description,
                difficulty: Convert.ToInt32(request.Difficulty));

            _context.Exercises.Add(newTask);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<TaskResponse> GetTask(string id)
    {
        try
        {
            ExerciseModel? task = await _context.Exercises.FindAsync(id);
            if (task == null)
                return null!;

            return new TaskResponse(task.ExerciseId.ToString(), task.Name, task.Description, task.Difficulty.ToString());
        }
        catch (Exception)
        {
            return null!;
        }
    }

    public async Task<bool> UpdateTask(string id, TaskUpdateRequest request)
    {
        try
        {
            ExerciseModel? task = await _context.Exercises.FindAsync(id);
            if (task == null)
                return false;

            task.Name = request.Name;
            task.Description = request.Description;
            task.Difficulty = request.Difficulty;

            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> DeleteTask(string id)
    {
        try
        {
            ExerciseModel? task = await _context.Exercises.FindAsync(id);
            if (task == null)
                return false;

            _context.Exercises.Remove(task);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}