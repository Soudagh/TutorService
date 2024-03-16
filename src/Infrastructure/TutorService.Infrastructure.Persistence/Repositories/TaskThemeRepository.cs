using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Models;
using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;
using TutorService.Infrastructure.Persistence.Contexts;

namespace TutorService.Infrastructure.Persistence.Repositories;

public class TaskThemeRepository: ITaskThemeRepository
{   
    private readonly ApplicationDbContext _context;
    
    public TaskThemeRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<bool> CreateTaskTheme(TaskThemeCreateRequest request)
    {
        try
        {
            var newTaskTheme = new TaskThemeModel(
                taskThemeId: 0,
                taskId: request.TaskId,
                themeId: request.ThemeId
            );
            _context.TaskThemes.Add(newTaskTheme);
            await _context.SaveChangesAsync();
            return true;
        }
        catch(Exception)
        {
            return false;
        }
    }

    public async Task<TaskThemeResponse> GetTaskTheme(string id)
    {
        try
        {
            TaskThemeModel? taskTheme = await _context.TaskThemes.FindAsync(id);
            if (taskTheme == null)
                return null!;

            return new TaskThemeResponse(taskTheme.TaskThemeId.ToString(), taskTheme.TaskId.ToString(),taskTheme.ThemeId.ToString());
        }
        catch (Exception)
        {
            return null!;
        }
    }

    public async Task<bool> UpdateTaskTheme(string id, TaskThemeUpdateRequest request)
    {
        try
        {
            TaskThemeModel? taskTheme = await _context.TaskThemes.FindAsync(id);
            if (taskTheme == null)
                return false;

            taskTheme.TaskId = request.TaskId;
            taskTheme.ThemeId = request.ThemeId;
            

            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> DeleteTaskTheme(string id)
    {
        try
        {
            TaskThemeModel? taskTheme = await _context.TaskThemes.FindAsync(id);
            if (taskTheme == null)
                return false;

            _context.TaskThemes.Remove(taskTheme);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    
}