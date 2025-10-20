using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet("all")]
        [Authorize(Roles = "Admin, Manager")]
        public IActionResult GetAll() => Ok("Only Admins and Managers can view this list");

        [HttpGet("employee")]
        [Authorize(Roles = "Employee")]
        public IActionResult EmployeAccess() => Ok("Employee-only endpoint!");
    }
}