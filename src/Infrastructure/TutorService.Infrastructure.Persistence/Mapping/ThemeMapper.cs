using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Entities;
using TutorService.Application.Models.Models;
using TutorService.Application.Models.Requests;

namespace TutorService.Infrastructure.Persistence.Mapping;

public class ThemeMapper
{
    public static Theme ModelToEntity(ThemeModel themeModel)
    {
        var theme = new Theme(
            themeId: themeModel.ThemeId,
            title: themeModel.Title,
            difficulty: themeModel.Difficulty);

        return theme;
    }

    public static ThemeModel EntityToModel(Theme theme)
    {
        var themeModel = new ThemeModel
        {
            ThemeId = theme.ThemeId,
            Title = theme.Title,
            Difficulty = theme.Difficulty,
        };

        return themeModel;
    }

    public static ThemeModel ThemeCreateToModel(ThemeCreateRequest request)
    {
        var themeModel = new ThemeModel
        {
            ThemeId = Guid.NewGuid(),
            Title = request.Title,
            Difficulty = request.Difficulty,
        };

        return themeModel;
    }

    public static ThemeModel ThemeUpdateToModel(ThemeUpdateRequest request)
    {
        var themeModel = new ThemeModel
        {
            ThemeId = Guid.Empty,
            Title = request.Title,
            Difficulty = request.Difficulty,
        };

        return themeModel;
    }
}