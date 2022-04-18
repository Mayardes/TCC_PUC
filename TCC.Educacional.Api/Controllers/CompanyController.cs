using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TCC.Educacional.Api.Models;

namespace TCC.Educacional.Api.Controllers
{
    [ApiController]
    [Route("v1/company/")]
    public class CompanyController : ControllerBase
    {
        [Authorize(Roles="Administrador")]
        [HttpPost]
        public async Task<IActionResult> CreateCompany([FromBody] Company model)
        {
            return Ok();
        }
    }
}
