namespace OnlineMuhasebeServer.Application.Services;

public interface IApiService
{
    string GetUserIdByToken();
    int GetYearByToken();
}
