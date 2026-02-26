using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPI.Controllers
{
    [Route("api/statusAPI")] // rota base: /api/health
    [ApiController] // ativaar validação automatica


    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Retorna um status 200 OK 
            return Ok("API está funcionando");
        }
    }

}
