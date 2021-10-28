using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Actividad2_Ejercicio2.Services
{
    public class AlcoholService
    {

        //Calcular el total de alcohol consumido
        public double CalcularTotalAlcoholConsumido(string bebida, int cantidad)
        {
            int totalBebidaConsumido;
            double totalAlcoholPorBebidaConsumido;
            switch (bebida)
            {
                case "cerveza":
                    totalBebidaConsumido = cantidad * 330;
                    totalAlcoholPorBebidaConsumido = totalBebidaConsumido * 0.05;
                    break;
                case "vino" or "cava":
                    totalBebidaConsumido = cantidad * 100;
                    totalAlcoholPorBebidaConsumido = totalBebidaConsumido * 0.12;
                    break;
                case "vermu":
                    totalBebidaConsumido = cantidad * 70;
                    totalAlcoholPorBebidaConsumido = totalBebidaConsumido * 0.24;
                    break;
                case "licor":
                    totalBebidaConsumido = cantidad * 45;
                    totalAlcoholPorBebidaConsumido = totalBebidaConsumido * 0.51;
                    break;
                case "brandy":
                    totalBebidaConsumido = cantidad * 45;
                    totalAlcoholPorBebidaConsumido = totalBebidaConsumido * 0.84;
                    break;
                case "combinado":
                    totalBebidaConsumido = cantidad * 50;
                    totalAlcoholPorBebidaConsumido = totalBebidaConsumido * 0.76;
                    break;
                default:
                    return totalAlcoholPorBebidaConsumido = 0;
                    break;
            }
            return totalAlcoholPorBebidaConsumido;
        }

        //Calcular la cantidad de alcohol que pasa directo a la sangre
        public double CalcularCantidadAlcoholSangre(double totalAlcoholPorBebidaConsumido)
        {
            double cantidadAlcoholSangre = (totalAlcoholPorBebidaConsumido * 15) / 100;
            return cantidadAlcoholSangre;
        }

        //Calcular la masa del etanol en sangre
        public double CalcularMasa(double cantidadAlcoholSangre)
        {
            double masa = 0.789 * cantidadAlcoholSangre;
            return masa;
        }

        //Calcular el volumen de la sangre de la persona considerando su peso
        public double CalcularVolumenSangre(double peso) 
        {
            double volumenSangre = (8 * peso / 100);
            return volumenSangre;
        }


        //Calcular el volumen de alcohol en la sangre (Alcoholemia)
        public double CalcularVolumenAlcohol(double masa, double volumenSangre)
        {
            double volumenAlcohol = masa / volumenSangre;
            return volumenAlcohol;
        }
        
        //Validar si es apto para conducir
        public string Validar(double volumenAlcohol) 
        {
            string resultado;

            if (volumenAlcohol > 0.8)
            {
                resultado = $"La cantidad de alcohol es: {volumenAlcohol}. Por tanto es superior a 0.8 y la persona no es apta para conducir.";
                return resultado;
            }
            resultado = $"La cantidad de alcohol es: {volumenAlcohol} y está por debajo de lo indicado en el reglamento. Buen viaje.";
            return resultado;
        }

        
    }
}
