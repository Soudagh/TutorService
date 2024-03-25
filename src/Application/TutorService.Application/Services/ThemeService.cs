using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Contracts;
using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Requests;

namespace TutorService.Application.Services;

public class ThemeService : IThemeService
{
    private readonly IThemeRepository _themeRepository;

    public ThemeService(IThemeRepository themeRepository)
    {
        _themeRepository = themeRepository;
    }

    public async Task<bool> CreateThemeAsync(ThemeCreateRequest request)
    {
        return await _themeRepository.CreateTheme(request);
    }

    public async Task<ThemeResponse> GetThemeAsync(string id)
    {
        ThemeResponse theme = await _themeRepository.GetTheme(id);
        return new ThemeResponse(theme.ThemeId, theme.Title, theme.Difficulty);
    }

    public async Task<bool> UpdateThemeAsync(string id, ThemeUpdateRequest request)
    {
        return await _themeRepository.UpdateTheme(id, request);
    }

    public async Task<bool> DeleteThemeAsync(string id)
    {
        return await _themeRepository.DeleteTheme(id);
    }
}