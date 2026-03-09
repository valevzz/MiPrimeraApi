using Microsoft.AspNetCore.Mvc;
namespace MiPrimeraAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class EsVocalController : ControllerBase
{
    [HttpGet("EsVocal")]

    public IActionResult Vocal([FromQuery] char letra)
    {
        string resultado;
        if ("AEIOUaeiou".Contains(letra))
        {
            resultado = "Es Vocal";
        }
        else
        {
            resultado = "No es vocal";
        }

        return Ok(resultado);
    }

    [HttpPost("Clasificacion")]

    public IActionResult Clasificacion()
    {
        List<char> Letras = new List<char> {'a','b', 'c','d','e','f','g','h','i','j','k','a','o','u','z'};
        List<char> Consonantes = new List<char> { };
        List<char> Vocales = new List<char> { };

        foreach (char letra in Letras)
        {
            if ("aeiou".Contains(letra))
            {
                Vocales.Add(letra);
            }
            else
            {
                Consonantes.Add(letra);
            }
        }

        int CantC = Consonantes.Count;
        int CantV = Vocales.Count;


        return Ok($"Vocales {string.Join("," ,Vocales)}\nLa cantidad de Vocales es:{CantV}\nConsonantes:{string.Join(",", Consonantes)}\nLa cantidad de Consonantes es:{CantV}");
    }






}
