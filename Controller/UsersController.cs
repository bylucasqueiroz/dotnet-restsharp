using dotnet_restsharp.Models;
using Microsoft.AspNetCore.Mvc;
using dotnet_restsharp.Services;

namespace dotnet_restsharp.Controller
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet("{login}")]
        public ActionResult<Users> GetUser(string login){
            return RestService.GetUsers(login);
        }
    }
}