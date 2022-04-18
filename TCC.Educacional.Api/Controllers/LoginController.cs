using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TCC.Educacional.Api.Data;
using TCC.Educacional.Api.Models;
using TCC.Educacional.Api.Service;

namespace TCC.Educacional.Api.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("v1/")]
    public class LoginController : Controller
    {
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> Authenticate(
            [FromServices] EducationalContext context,
            [FromBody] User model)
        {
            var user = await context.Users
                .AsNoTracking()
                .Where(x => x.Name == model.Name && x.Password == model.Password)
                .FirstOrDefaultAsync();

            if (user == null)
                return BadRequest(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(user);

            return new
            {
                user = user,
                token = token
            };
        }
    }
}
