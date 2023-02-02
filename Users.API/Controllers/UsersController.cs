using Microsoft.AspNetCore.Mvc;
using Models;

namespace Users.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public User Get()
    {
        return new User
        {
            FirstName = "kakha",
            LastName = "tezelashvili"
        };
    }
}
