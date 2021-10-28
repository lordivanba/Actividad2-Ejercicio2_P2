using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actividad2_Ejercicio2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
/*
 *Universidad Tecnologica Metropolitana
 * Aplicaciones web orietadas a servicios
 * Maestro: Ing. Joel I. Chuc
 * Alumno: Ivan Canto
 * Cuarto Cuatrimestre
 * Grupo A
 * Segundo parcial
 */
