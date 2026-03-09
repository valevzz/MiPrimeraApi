using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Mvc;
namespace MiPrimeraAPI.Controllers;

[ApiController]
[Route("api/[controller]")]


public class ConversionController : ControllerBase
{
    [HttpGet("Dlls-peso")]

    public IActionResult DolaresApeso([FromQuery] int Dolares, [FromQuery] float TipoCambio)
    {
        float Peso = Dolares * TipoCambio;

        return Ok($"Pesos:{Peso} ");
    }
    
     [HttpGet("Dlls-euro")]

    public IActionResult DolaresAeuros([FromQuery] int Dolares, [FromQuery] float TipoCambio)
    {
        float Euros = Dolares * TipoCambio;

        return Ok($"El total de Euros es:{Euros} ");
    }
    
    
    
    [HttpGet("Peso-Dlls")]

    public IActionResult Dolares([FromQuery] int Peso, [FromQuery] float TipoCambio)
    {
        float dlls = Peso / TipoCambio;

        return Ok($"Usted solo podra adquirir: {dlls} dolares");
    }

    [HttpGet("Peso-Euro")]

    public IActionResult PesoEuro([FromQuery] int Peso, [FromQuery] float TipoCambio)
    {
        float euros = Peso / TipoCambio;

        return Ok($"Usted solo podra adquirir: {euros} euros");
    }

    [HttpGet("Euro-Peso")]

    public IActionResult EuroPeso([FromQuery] int Euros, [FromQuery] float TipoCambio)
    {
        float peso = Euros *  TipoCambio;

        return Ok($"El total es: {peso} pesos");
    }

    [HttpGet("Euro-Dlls")]
        public IActionResult EuroDlls([FromQuery] double Euros)
    {
        double dlls = Euros *  .87;

        return Ok($"El total es: {dlls} dlls");
    }

    [HttpGet("Km-Millas")]
    public IActionResult KilometrosMillas([FromQuery] int Kilometro)
    {
        double Millas = Kilometro * 0.621371;

        return Ok($"El total de Millas es: {Millas}");
    }


    [HttpGet("Millas-Km")]
    public IActionResult MillasKm([FromQuery] double Millas)
    {
        double Km = Millas * 1.60934;
        return Ok($"El total de Kilometros es: {Km}");
    }


}
