using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TCC.Educacional.Api.Data;
using TCC.Educacional.Api.Models;

namespace TCC.Educacional.Api.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("v1/user/")]
    public class UserController : ControllerBase
    {
        private readonly EducationalContext _context;
        public UserController(EducationalContext context)
        {
            _context = context;
        }

        [Route("")]
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody]User model)
        {
            _context.Users.Add(model);
            await _context.SaveChangesAsync();
            return Ok(model);
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllAsync()
        {   
            var user = await _context.Users.AsNoTracking().Include(x => x.Role).FirstOrDefaultAsync();
            return Ok(user);
        } 

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok();
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateAsync(User model, int id)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok();
        }
    }
}
