using Microsoft.AspNetCore.Mvc;

namespace csharp_web_performance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetUsuario()
        {
            return Ok();
        }
    }
}
