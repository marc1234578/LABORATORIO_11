using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion;
            do
            {
                INTERFAZ.MostrarMenu();
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            INTERFAZ.RegistrarNota();
                            if (int.TryParse(Console.ReadLine(), out opcion))
                            {
                                switch (opcion)
                                {
                                    case 1:
                                        INTERFAZ.RegistrarNota();
                                        break;
                                    case 2: break;
                                    default: Console.WriteLine("Opción no válida. Seleccionando la opción 2 para regresar."); break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Opción no válida. Seleccionando la opción 2 para regresar.");
                            }

                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            INTERFAZ.MostrarNotaMayor();
                            break;
                        case 3:
                            Console.Clear();
                            INTERFAZ.MostrarNotaMenor();
                            break;
                        case 4:
                            Console.Clear();
                            INTERFAZ.BuscarNota();
                            break;
                        case 5:
                            Console.Clear();
                            INTERFAZ.ModificarNota();
                            break;
                        case 6:
                            Console.Clear();
                            INTERFAZ.MostrarNotasRegistradas();
                            break;
                        case 7:
                            Console.WriteLine("¡Hasta luego!");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                            break;
                    }
                }
            } while (opcion != 7);
            Console.ReadKey();
        }
    }
}
