using System;
using System.Linq;
using Entidades;

namespace Presentacion
{
    public class PresentacionPregrado: PresentarEstudiante
    {
        public void Lista()
        {
            Console.Clear();
            Console.WriteLine("LISTA DE PREGRADO");

            foreach (var es in servicio.Listar().Where(estudiante => estudiante.GetType() == typeof(Pregrado)).Cast<Pregrado>())
            {
                Console.WriteLine($"Documento: {es.NoDocumento}");
                Console.WriteLine($"Nombres y Apellidos: {es.Nombre} {es.Apellido}");
                Console.WriteLine($"Programa: {es.Programa}");
                Console.WriteLine($"Semestre: {es.Semestre}");
                Console.WriteLine($"Corte 1: {es.PromedioCorte1}");
                Console.WriteLine($"Corte 2: {es.PromedioCorte2}");
                Console.WriteLine($"Corte 3: {es.PromedioCorte3}");
                
                Console.WriteLine();
            }

            Console.Write("Digite cualquier letra para continuar... ");Console.ReadKey();
        }
    }
}