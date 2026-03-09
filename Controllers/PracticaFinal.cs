using Microsoft.AspNetCore.Mvc;
namespace MiPrimeraAPI.Controllers;

[ApiController]

[Route("api/[controller]")]

public class PracticaFinal : ControllerBase
{
        [HttpGet("Suma")]
        public IActionResult Sumar ([FromQuery] int num1, [FromQuery] int num2)
        {
            int resultado = CalcularSuma(num1,num2);
            return Ok($"El resultado es: {resultado}");
        }


        [HttpGet("Promedios")]
        public IActionResult Promedios ([FromQuery] int c1, [FromQuery] int c2, [FromQuery] int c3)
        {
            int resultado = PromedioCalificaciones(c1,c2,c3);
            return Ok($"El resultado es: {resultado}");
        }

        [HttpGet("Tablas-de-Multiplicar")]
        public IActionResult Tablas ([FromQuery] int num)
        {
            List<string> listas = TablaDeMultiplicar(num);
            return Ok(listas);
        }
    


    

    private int CalcularSuma(int num1, int num2)
    {
        return num1 + num2;
    }

    private int PromedioCalificaciones (int c1, int c2, int c3)
    {
        return (c1 + c2 + c3)/3;
    }


    private List<string> TablaDeMultiplicar (int num)
    {
        List<string> resultados = new List <string>();

        for (int i = 1; i <= 10; i++)
        {
            int producto = num * i;
            string linea = ($"{num} x {i} = {producto}");
            resultados.Add(linea);

        }
         return (resultados);

    }





}