using TutorService.Application.Models;
using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Entities;
using TutorService.Application.Models.Requests;

namespace TutorService.Infrastructure.Persistence.Mapping;

public class ThemeMapper
{
    public static Theme ModelToEntity(ThemeModel themeModel)
    {
        var theme = new Theme(
            themeId: themeModel.ThemeId,
            title: themeModel.Title,
            difficulty: themeModel.Difficulty
        );
        return theme;
    }

    public static ThemeModel EntityToModel(Theme theme)
    {
        var themeModel = new ThemeModel(
            themeId: theme.ThemeId,
            title: theme.Title,
            difficulty: theme.Difficulty
        );
        return themeModel;
    }

    public ThemeModel ThemeCreateToModel(ThemeCreateRequest request)
    {
        var themeModel = new ThemeModel(
            themeId: Guid.NewGuid(),
            title: request.Title,
            difficulty: request.Difficulty
        );
        return themeModel;
    }

    public ThemeModel ThemeUpdateToModel(ThemeUpdateRequest request)
    {
        var themeModel = new ThemeModel(
            themeId: Guid.Empty,
            title: request.Title,
            difficulty: request.Difficulty
        );
        return themeModel;
    }
}