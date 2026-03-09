using Microsoft.AspNetCore.Mvc;
namespace MiPrimeraAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class PracticaExamenController: ControllerBase
{
    [HttpGet("EspaciosEnBlanco")]

    
    public IActionResult Espacios ([FromQuery] string Texto)
    {
        int contador = 0;
        foreach (char c in Texto)
        {
            if (c == ' ')
            {
                contador ++;
            }
        }
        return Ok($"El numero de espacios es blanco es: {contador}");
    }


    [HttpGet("PalabraPalindoma")]

    public IActionResult Palindroma ([FromQuery] string palabra)
    {
        string invertida = new string(palabra.Reverse().ToArray());
        string respuesta;
        if (palabra == invertida)
        {
            respuesta = ("Es polindroma");
        }
        else 
        {
            respuesta = ("No es polindroma");
        }

        return Ok($"La palabra {respuesta}");

    }

    [HttpGet("NumeroMayor")]   

    public IActionResult Numeros ([FromQuery] int num1, [FromQuery] int num2) 
    {
        string resp;
        if (num1 > num2)
        {
            resp = ($"El numero mayor es: {num1}");
        }
        else
        {
            resp = ($"El numero mayor es: {num2}");
        }
        return Ok(resp);
        
    }

    [HttpGet("GradosFahrenheit-Celsius")]

    public IActionResult Grados ([FromQuery] int grados)
    {
        int celsius = (grados - 32) * 5 /9;
        return Ok($"Los grados celsius son: {celsius}");   
    } 









}
