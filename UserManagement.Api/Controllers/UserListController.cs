using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [Route("api/userlist")]
    [ApiController]
    [Authorize(Roles ="Admin")]
    public class UserListController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var uerlist= await Task.FromResult(new string[] { "Virat", "Messi", "Ozil", "Lara", "MS Dhoni" });
            return Ok(uerlist);
        }
    }
}
