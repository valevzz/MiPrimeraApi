using Microsoft.AspNetCore.Mvc;

namespace MiPrimeraAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ImportanteController : ControllerBase
{
    [HttpGet("Factorial")]

    public IActionResult Factorial ([FromQuery] int num)
    {
        long resultado = 1;
        for (int i = 1; i <= num; i++)
        {
            resultado *= i;
        }
        return Ok(new {Numero = num ,Factorial = resultado});
    }


    [HttpGet("PalabraPalindroma")]
    public IActionResult PalabraPalindroma ([FromQuery] string palabra)
    {
        string original = palabra.ToLower();

            char[] array = original.ToCharArray();
            Array.Reverse(array);
            string invertida = new string(array);

            bool esPalindromo = original == invertida;

         return Ok(new { Palabra = palabra, Palindromo = esPalindromo });
    }

    [HttpGet("PorcentajeCantidad")]
     
    public IActionResult PorcentajeCantidad([FromQuery] int num, [FromQuery] int porc)
    {
        int resultado = num * porc / 100;

        return Ok ($"El {porc}% de {num} es: {resultado}");


    }

}






