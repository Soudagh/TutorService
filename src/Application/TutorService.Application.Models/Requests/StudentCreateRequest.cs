using System.Collections.ObjectModel;

namespace TutorService.Application.Models.Requests;

public record StudentCreateRequest(
    int StudentId,
    int StudentUserId,
    int TutorId,
    int ThemeId,
    Collection<TaskModel> CompletedTasks,
    Collection<TaskModel> SuggestedTasks);