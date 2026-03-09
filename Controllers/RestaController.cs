using Microsoft.AspNetCore.Mvc;
namespace MiPrimeraAPI.Controllers;

[ApiController]
[Route("api[controller]")]

public class OperacionesController : ControllerBase
{
    [HttpPost("Realizar")]

    public IActionResult Operaciones()
    {
        int num1 = 4;
        int num2 = 8;

        int suma = num1 + num2;
        int resta = num1 - num2;
        int multi = num1 * num2;

        var resultado = $"Resultados:\n Suma:{suma}\n Resta:{resta} \n Multiplicación:{multi}";

        return Ok(resultado);

    }

    [HttpGet("Cuadrado*")]

    public IActionResult Cuadrado([FromQuery] int num)
    {
        int resultado = num * num;

        return Ok($"El resultado es: {resultado}");
    }





}
