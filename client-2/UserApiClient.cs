namespace client_2;

public class UserApiClient(HttpClient httpClient)
{
    public async Task<string> GetUsername()
    {
        var response = await httpClient.GetAsync("/api/users");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}
