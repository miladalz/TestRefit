using Microsoft.AspNetCore.Mvc;
using TestRefit.Interface;
using TestRefit.Model;

namespace TestRefit.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUsers _users;

    public UserController(IUsers users)
    {
        _users = users;
    }

    [HttpGet(Name = "GetUsers")]
    public async Task<IEnumerable<User>> GetUsers()
    {
        var result = await _users.GetAll();
        return result;
    }
}

