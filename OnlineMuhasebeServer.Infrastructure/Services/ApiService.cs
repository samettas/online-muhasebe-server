using Microsoft.AspNetCore.Http;
using OnlineMuhasebeServer.Application.Services;

namespace OnlineMuhasebeServer.Infrastructure.Services;

public sealed class ApiService : IApiService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ApiService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string GetUserIdByToken()
    {
        var userId = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(p => p.Type.Contains("authentication"))?.Value;
        
        return userId ?? string.Empty;
    }

    public int GetYearByToken()
    {
        var year = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(p => p.Type.Contains(""))?.Value;
        return year is null ? Convert.ToInt16(year) : DateTime.Now.Year;
    }
}
