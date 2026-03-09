using Microsoft.AspNetCore.Mvc;
namespace MiPrimeraAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class FigurasController : ControllerBase
{
    [HttpGet("Area-Cuadrado")]

    public IActionResult Area([FromQuery] int lado)
    {
        int area = lado * lado;
        return Ok($"El Area del Cuadrado es: {area}");
    }


    [HttpGet("Perimetro-Cuadrado")]
    public IActionResult Perimetro([FromQuery] int lado)
    {
        int perimetro = lado * 4;
        return Ok($"El Perimetro del cuadrado es: {perimetro}");
    }


    [HttpGet("CirculoA")]
    public IActionResult Area([FromQuery] double radio)
    {
        double area = 3.1416 * radio * radio;
       
        return Ok($"El area es: {area} ");
    }

    [HttpGet("CirculoP")]
    public IActionResult Perimetro([FromQuery] double radio)
    {
        
        double perimetrop = 2 * Math.PI * radio;

        return Ok($"El perimetro es: {perimetrop}");
    }

    [HttpGet("RectanguloA")]
    public IActionResult AreaRec([FromQuery] double baseR , [FromQuery] double altura)
    {
        
        double res = (baseR * altura);

        return Ok($"El Area es: {res}");
    }
    
        [HttpGet("Triangulo-Area")]
    public IActionResult AreaT([FromQuery] double baseT , [FromQuery] double altura)
    {
        
        double res = (baseT * altura)/2;

        return Ok($"El Area del triangulo es: {res}");
    }

}
