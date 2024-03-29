using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Entities;
using TutorService.Application.Models.Models;
using TutorService.Infrastructure.Persistence.Contexts;
using TutorService.Infrastructure.Persistence.Mapping;

namespace TutorService.Infrastructure.Persistence.Repositories;

public class ThemeRepository(ApplicationDbContext context) : IThemeRepository
{
    public async Task<bool> CreateTheme(ThemeModel themeModel)
    {
        try
        {
            var theme = ThemeMapper.ModelToEntity(themeModel);
            context.Add(entity: theme);
            await context.SaveChangesAsync();

            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public async Task<ThemeResponse> GetTheme(string themeId)
    {
        try
        {
            Theme? theme = await context.Themes.FindAsync(new Guid(themeId));
            if (theme == null)
            {
                return null!;
            }

            // Theme theme = ThemeMapper.ModelToEntity(themeModel);
            return new ThemeResponse(
                theme.ThemeId.ToString(),
                theme.Title,
                theme.Difficulty);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null!;
        }
    }

    public async Task<bool> UpdateTheme(string themeId, ThemeModel themeModel)
    {
        try
        {
            Theme? theme = await context.Themes.FindAsync(new Guid(themeId));
            if (theme == null)
            {
                return false;
            }

            // Theme theme = ThemeMapper.ModelToEntity(foundThemeModel);
            theme.Title = themeModel.Title;
            theme.Difficulty = themeModel.Difficulty;

            await context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> DeleteTheme(string themeId)
    {
        try
        {
            Theme? theme = await context.Themes.FindAsync(new Guid(themeId));
            if (theme == null)
            {
                return false;
            }

            context.Themes.Remove(theme);
            await context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}