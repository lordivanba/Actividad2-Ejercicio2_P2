using Actividad2_Ejercicio2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actividad2_Ejercicio2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlcoholController : ControllerBase
    {

        [HttpGet]
        public IActionResult CalcularVolumen(Alcohol oAlcohol)
        {
            var srv = new AlcoholService();

            var totalAlcoholPorBebidaConsumido = srv.CalcularTotalAlcoholConsumido(oAlcohol.bebida, oAlcohol.cantidad);
            
            if(totalAlcoholPorBebidaConsumido == 0) 
            {
                return Ok("Bebida ingresada no valida.");
            }

            var cantidadAlcoholSangre = srv.CalcularCantidadAlcoholSangre(totalAlcoholPorBebidaConsumido);

            var masa = srv.CalcularMasa(cantidadAlcoholSangre);

            var volumenSangre = srv.CalcularVolumenSangre(oAlcohol.peso);

            var volumenAlcohol = srv.CalcularVolumenAlcohol(masa, volumenSangre);

            var resultado = srv.Validar(volumenAlcohol);

            return Ok(resultado);
        }

    }
}
