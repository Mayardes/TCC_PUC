using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var user = await _context.Users
                .AsNoTracking()
                .Include(x => x.Role)
                .FirstOrDefaultAsync();

            return Ok(user);
        } 

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var user = await _context.Users
                       .AsNoTracking()
                       .Include(x => x.Role)
                       .FirstOrDefaultAsync(x => x.Id == id);
            if(user == null)
                return NotFound(new { message = "Usuário não encontrado"});

            return Ok(user);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateAsync(User model, int id)
        {
            var user = await _context.Users
                       .Include(x => x.Role)
                       .FirstOrDefaultAsync(x => x.Id == id);
            if(user == null)
                return NotFound(new { message = "Usuário não encontrado"});
            else
            {
                user.Name = model.Name;
                user.Password = model.Password;
                user.RoleId = model.RoleId;
                _context.Update(user);
            }
               
            return Ok(user);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

            if(user == null)
                return NotFound(new { message = "Usuário não encontrado"});
            else
            {
                _context.Remove(user);
                await _context.SaveChangesAsync();
            }

            return Ok(user);
        }
    }
}
