using System;
using Logica;

namespace Presentacion
{
    public class PresentarEstudiante
    {
        protected ServicioEstudiante servicio = new ServicioEstudiante();
        
        public void PresentarPromedio()
        {
            Console.Clear();

            Console.Write("Escriba la materia a calcular promedio: ");
            var materia = Console.ReadLine().ToUpper();
            
            Console.WriteLine(servicio.Promedio(materia));
            Console.Write("Escriba ENTER para continuar... ");Console.ReadKey();
        }

        public void PresentarDestacado()
        {
            Console.Clear();

            Console.Write("Escriba la materia a conocer estudiantes destacados: ");
            var materia = Console.ReadLine().ToUpper();
            
            Console.WriteLine(servicio.Destacado(materia));
            Console.Write("Escriba ENTER para continuar... ");Console.ReadKey();
        }
    }
}