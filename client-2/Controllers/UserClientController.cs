using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;

namespace client_2.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserClientController : ControllerBase
{
    private readonly UserApiClient _userApiClient;
    public UserClientController(UserApiClient userApiClient)
    {
        _userApiClient = userApiClient;
    }
    [HttpGet]
    public async Task<string> GetUsername()
    {
        return await _userApiClient.GetUsername();
    }
}
