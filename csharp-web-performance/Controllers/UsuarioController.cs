using csharp_web_performance.Model;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;

namespace csharp_web_performance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetUsuario()
        {
            string connectionString = "Server=localhost;Database=sys;User=root;Password=123;";
            using var connection = new MySqlConnection(connectionString);
            await connection.OpenAsync();
            string query = "select id, nome from usuarios";
            var usuarios = await connection.QueryAsync<Usuario>(query);

            return Ok(usuarios);
        }
    }
}
