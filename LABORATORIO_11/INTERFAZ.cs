using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_11
{
    internal class INTERFAZ
    {
        static List<int> notas = new List<int>();
        public static void MostrarMenu()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Casos con arreglos");
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar notas");
            Console.WriteLine("2: Hallar la nota mayor");
            Console.WriteLine("3: Hallar la nota menor");
            Console.WriteLine("4: Encontrar una nota");
            Console.WriteLine("5: Modificar una nota");
            Console.WriteLine("6: Ver notas registradas");
            Console.WriteLine("7: Salir");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción: ");
        }

        public static void RegistrarNota()
        {
            Console.Clear(); // Limpiar la pantalla antes de registrar la nota.
            int numeroNota = notas.Count + 1; // Obtener el número de la nota.
            Console.WriteLine("================================");
            Console.WriteLine("Registrar una nota");
            Console.Write($"Ingresa la nota Nro {numeroNota}: ");
            if (int.TryParse(Console.ReadLine(), out int nota))
            {
                notas.Add(nota);
                Console.WriteLine("Nota registrada con éxito.");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
            }
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar otra nota");
            Console.WriteLine("2: Regresar");

            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        RegistrarNota(); // Llamada recursiva para registrar otra nota con numeración incrementada.
                        break;
                    case 2:
                        // No hacer nada, regresar al menú principal.
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Seleccionando la opción 2 para regresar.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opción no válida. Seleccionando la opción 2 para regresar.");
            }

            Console.Clear();
        }

        public static void MostrarNotaMayor()
        {
            if (notas.Count == 0)
            {
                Console.WriteLine("No hay notas registradas.");
            }
            else
            {
                Console.WriteLine("================================");
                Console.WriteLine("La nota mayor");
                Console.WriteLine("================================");
                int notaMayor = notas.Max();
                string notasRegistradas = string.Join(" ", notas);
                Console.WriteLine("La nota mayor es: " + notaMayor);
                Console.WriteLine(notasRegistradas);
            }
            Console.WriteLine("================================");
            Console.WriteLine("1: Regresar");
            Console.WriteLine(" ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void MostrarNotaMenor()
        {
            if (notas.Count == 0)
            {
                Console.WriteLine("No hay notas registradas.");
            }
            else
            {
                Console.WriteLine("================================");
                Console.WriteLine("La nota menor");
                Console.WriteLine("================================");
                int nmenor = notas.Min();
                string nRegistradas = string.Join(" ", notas);
                Console.WriteLine("La nota mayor es: " + nmenor);
                Console.WriteLine(nRegistradas);
            }
            Console.WriteLine("================================");
            Console.WriteLine("1: Regresar");
            Console.WriteLine(" ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void BuscarNota()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Buscar nota");
            Console.Write("Ingrese la nota a buscar: ");
            if (int.TryParse(Console.ReadLine(), out int notaBuscada))
            {
                int index = notas.IndexOf(notaBuscada);
                if (index != -1)
                {
                    Console.WriteLine("La nota está en la posición " + index);
                    Console.WriteLine("================================");

                    for (int i = 0; i < notas.Count; i++)
                    {
                        Console.WriteLine($"{i} -> {notas[i]}");
                    }

                    Console.WriteLine("================================");
                    Console.WriteLine("1: Regresar");
                }
                else
                {
                    Console.WriteLine("La nota no se encontró en la lista.");
                    Console.WriteLine("================================");
                    Console.WriteLine("1: Regresar");
                }
            }
            Console.WriteLine(" ");
            Console.ReadKey();
            Console.Clear();
        }


        public static void ModificarNota()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Modificar nota");
            Console.WriteLine("================================");
            if (notas.Count == 0)
            {
                Console.WriteLine("No hay notas registradas para modificar.");
            }
            else
            {
                Console.Write("Ingrese la posición: ");
                if (int.TryParse(Console.ReadLine(), out int posicion))
                {
                    if (posicion >= 1 && posicion <= notas.Count)
                    {
                        Console.Write("Ingrese el nuevo valor: ");
                        if (int.TryParse(Console.ReadLine(), out int nuevoValor))
                        {
                            int notaAntes = notas[posicion - 1]; // Nota antes de la modificación
                            notas[posicion - 1] = nuevoValor;

                            Console.WriteLine("Antes: " + notaAntes);
                            Console.WriteLine("Después: " + nuevoValor);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Posición no válida. Por favor, ingrese una posición válida.");
                    }
                }
            }
            Console.WriteLine("================================");
            Console.WriteLine("1: Regresar");
            Console.ReadKey();
            Console.Clear();
        }


        public static void MostrarNotasRegistradas()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Notas registradas:");
            if (notas.Count > 1)
            {
                Console.WriteLine(string.Join(" ", notas));
            }
            else
            {
                Console.WriteLine("No hay notas registradas.");
            }
            Console.WriteLine("================================");
            Console.WriteLine(" ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
