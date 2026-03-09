using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
namespace MiPrimeraAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class PromediosController : ControllerBase
{
    [HttpGet("Promedio3")]

    public IActionResult Calificaciones3([FromQuery] float c1, [FromQuery] float c2, [FromQuery] float c3)
    {
        float resultado = (c1 + c2 + c3) / 3;
        return Ok($"El promedio es: {resultado}");
    }

    [HttpPost("ListaPromedios")]

    public IActionResult ListaPromedios()
    {
        List<int> Calificaciones = new List<int> { 60, 70, 80, 90, 100, 82, 77 };
        float suma = 0;

        foreach (int Calificacion in Calificaciones)
        {
            suma += Calificacion;
        }

        float promedio = suma / Calificaciones.Count;
        return Ok($"Calificaciones = {string.Join(", ", Calificaciones)} \n Promedio = {promedio}");
    }

        [HttpGet("Porcentaje")]
        public IActionResult porcentaje([FromQuery] int num1, [FromQuery] int por)
        {
            int resultado = (num1 * por)/100;
            return Ok($"El resultado es: {resultado}");
        }

    
}
