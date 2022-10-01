using System;
using System.Linq;
using Entidades;

namespace Presentacion
{
    public class PresentacionPostgrado : PresentarEstudiante
    {
        public void Lista()
        {
            Console.Clear();
            Console.WriteLine("LISTA DE POSTGRADOS");

            foreach (var es in servicio.Listar().Where(estudiante => estudiante.GetType() == typeof(Postgrado))
                         .Cast<Postgrado>())
            {
                Console.WriteLine($"Documento: {es.NoDocumento}");
                Console.WriteLine($"Nombres y Apellidos: {es.Nombre} {es.Apellido}");
                Console.WriteLine($"Programa: {es.Programa}");
                Console.WriteLine($"Semestre: {es.Semestre}");
                Console.WriteLine($"Promedio: {es.PromedioSemestre}");
                
                Console.WriteLine();
            }
            Console.Write("Digite cualquier letra para continuar... ");Console.ReadKey();
        }
    }
}