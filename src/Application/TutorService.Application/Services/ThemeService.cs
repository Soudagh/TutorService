using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Contracts;
using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Models;

namespace TutorService.Application.Services;

public class ThemeService : IThemeService
{
    private readonly IThemeRepository _themeRepository;

    public ThemeService(IThemeRepository themeRepository)
    {
        _themeRepository = themeRepository;
    }

    public async Task<bool> CreateThemeAsync(ThemeModel themeModel)
    {
        return await _themeRepository.CreateTheme(themeModel);
    }

    public async Task<ThemeResponse> GetThemeAsync(string themeId)
    {
        ThemeResponse theme = await _themeRepository.GetTheme(themeId);
        return new ThemeResponse(theme.ThemeId, theme.Title, theme.Difficulty);
    }

    public async Task<bool> UpdateThemeAsync(string themeId, ThemeModel themeModel)
    {
        return await _themeRepository.UpdateTheme(themeId, themeModel);
    }

    public async Task<bool> DeleteThemeAsync(string themeId)
    {
        return await _themeRepository.DeleteTheme(themeId);
    }
}