using System;

namespace Presentacion
{
    public class PresentacionPrograma
    {
        private PresentacionPostgrado presentacionPostgrado = new PresentacionPostgrado();
        private PresentacionPregrado presentacionPregrado = new PresentacionPregrado();
        private PresentarEstudiante presentarEstudiante = new PresentarEstudiante();

        public void Menu()
        {
            byte op;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("1. ESTUDIANTES DE PREGRADO");
                Console.WriteLine("2. ESTUDIANTES DE POSTGRADO");
                Console.WriteLine("3. PROMEDIO POR PROGRAMA");
                Console.WriteLine("4. ESTUDIANTES DESTACADO");
                Console.WriteLine("5. Salir");
                
                Console.Write("\nDigite una opción: ");
                op = byte.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        presentacionPregrado.Lista();
                        break;
                    case 2:
                        presentacionPostgrado.Lista();
                        break;
                    case 3:
                        presentarEstudiante.PresentarPromedio();
                        break;
                    case 4:
                        presentarEstudiante.PresentarDestacado();
                        break;
                    case 5:
                        Console.WriteLine("\nGracias por usar el programa");
                        break;
                }
            } while (op != 5);
        }
    }
}