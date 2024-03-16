using System.Collections.ObjectModel;

namespace TutorService.Application.Models.Responses;

public record StudentResponse(
    string StudentId,
    string ThemeId,
    Collection<TaskModel> CompletedTasks,
    Collection<TaskModel> SuggestedTasks);