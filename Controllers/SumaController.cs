using Microsoft.AspNetCore.Mvc;

namespace MiPrimeraAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraController : ControllerBase
    {
        
        [HttpGet("sumar")]
        public IActionResult Sumar([FromQuery] int num1, [FromQuery] int num2)
        {
            int resultado = num1 + num2;
            return Ok(new { numero1 = num1, numero2 = num2, suma = resultado });
        }

[HttpGet("multi")]
        public IActionResult Multi([FromQuery] int num1, [FromQuery] int num2)
        {
            int resultado = num1 * num2;
            return Ok(new { numero1 = num1, numero2 = num2, resultado = resultado });
        }
[HttpGet("resta")]
        public IActionResult Resta([FromQuery] int num1, [FromQuery] int num2)
        {
            int resultado = num1 - num2;
            return Ok(new { numero1 = num1, numero2 = num2, resultado = resultado });
        }



    }
}
