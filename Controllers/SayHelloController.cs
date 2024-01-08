using Microsoft.AspNetCore.Mvc;

namespace SayHello.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SayHelloController
{

    [HttpGet]
    [Route("username/{username}")]
    public string GetUsername(string username)
    {
        return "Hello, " + username;
    }
}
