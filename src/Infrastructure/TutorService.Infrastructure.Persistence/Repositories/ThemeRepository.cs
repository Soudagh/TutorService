using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Models;
using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;
using TutorService.Infrastructure.Persistence.Contexts;

namespace TutorService.Infrastructure.Persistence.Repositories;

public class ThemeRepository : IThemeRepository
{
     private readonly ApplicationDbContext _context;

     public ThemeRepository(ApplicationDbContext context)
    {
        _context = context;
    }

     public async Task<bool> CreateTheme(ThemeCreateRequest request)
    {
        try
        {
            var newTheme = new ThemeModel(
                themeId: 0,
                title: request.Title,
                difficulty: Convert.ToInt32(request.Difficulty));

            _context.Themes.Add(newTheme);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

     public async Task<ThemeResponse> GetTheme(string id)
    {
        try
        {
            ThemeModel? theme = await _context.Themes.FindAsync(id);
            if (theme == null)
                return null!;

            return new ThemeResponse(theme.ThemeId.ToString(), theme.Title, theme.Difficulty);
        }
        catch (Exception)
        {
            return null!;
        }
    }

     public async Task<bool> UpdateTheme(string id, ThemeUpdateRequest request)
    {
        try
        {
            ThemeModel? theme = await _context.Themes.FindAsync(id);
            if (theme == null)
                return false;

            theme.Title = request.Title;
            theme.Difficulty = request.Difficulty;

            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

     public async Task<bool> DeleteTheme(string id)
    {
        try
        {
            ThemeModel? theme = await _context.Themes.FindAsync(id);
            if (theme == null)
                return false;

            _context.Themes.Remove(theme);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}