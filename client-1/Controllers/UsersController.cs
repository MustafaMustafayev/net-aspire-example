using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace client_1.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpGet]
    public string GetUsername()
    {
        return "test username";
    }
}
