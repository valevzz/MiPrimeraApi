namespace MiPrimeraAPI.Controllers;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


    [ApiController]
    [Route("api/[controller]")]
    public class LetrasController : ControllerBase
    {
        [HttpGet("clasificar")]
        public IActionResult ClasificarLetras()
        {
            // Lista de letras
            List<char> letras = new List<char> { 'a', 'b', 'c', 'd', 'e' };
            List<string> resultado = new List<string>();

            foreach (char letra in letras)
            {
                if ("aeiou".Contains(letra))
                {
                    resultado.Add($"{letra} es una vocal");
                }
                else
                {
                    resultado.Add($"{letra} es una consonante");
                }
            }

            return Ok(resultado);
        }
    }
