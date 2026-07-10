using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static string[,] vehiculos = new string[10, 3];

    private static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("===== MENU PARQUEO =====");
            Console.WriteLine("1. Registrar Vehículo");
            Console.WriteLine("2. Mostrar Vehículos");
            Console.WriteLine("3. Actualizar Vehículo");
            Console.WriteLine("4. Eliminar Vehículo");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("=== REGISTRAR VEHÍCULO ===");
                    Registrar();
                    Pausa();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("=== MOSTRAR VEHÍCULOS ===");
                    MostrarV();
                    Pausa();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("=== ACTUALIZAR VEHÍCULO ===");
                    Actualizar();
                    Pausa();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("=== ELIMINAR VEHÍCULO ===");
                    Eliminar();
                    Pausa();
                    break;

                case 5:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    Pausa();
                    break;
            }
        } while (opcion != 5);
    }

    static void Registrar()
    {
        bool registrado = false;
        for (int i = 0; i < 10; i++)
        {
            if (string.IsNullOrEmpty(vehiculos[i, 0]))
            {
                Console.Write("Número de Placa: ");
                vehiculos[i, 0] = Console.ReadLine();

                Console.Write("Nombre del Propietario: ");
                vehiculos[i, 1] = Console.ReadLine();

                Console.Write("Marca del Vehículo: ");
                vehiculos[i, 2] = Console.ReadLine();

                Console.WriteLine("\nVehículo registrado exitosamente.");
                registrado = true;
                break;
            }
        }

        if (!registrado)
        {
            Console.WriteLine("\nEl parqueo está lleno.");
        }
    }

    static void MostrarV()
    {
        Console.WriteLine("\nPLACA\t\tPROPIETARIO\t\tMARCA");
        Console.WriteLine("-----------------------------------------------------");
        for (int i = 0; i < 10; i++)
        {
            if (!string.IsNullOrEmpty(vehiculos[i, 0]))
            {
                Console.WriteLine(
                    vehiculos[i, 0] + "\t\t" +
                    vehiculos[i, 1] + "\t\t" +
                    vehiculos[i, 2]);
            }
        }
    }

    static void Actualizar()
    {
        string placa;
        bool encontrado = false;
        Console.Write("Placa del vehículo a buscar: ");
        placa = Console.ReadLine();

        for (int i = 0; i < 10; i++)
        {
            if (vehiculos[i, 0] == placa)
            {
                Console.Write("Nuevo Propietario: ");
                vehiculos[i, 1] = Console.ReadLine();

                Console.Write("Nueva Marca: ");
                vehiculos[i, 2] = Console.ReadLine();

                Console.WriteLine("\nRegistro actualizado.");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("\nPlaca no encontrada.");
        }
    }

    static void Eliminar()
    {
        string placa;
        bool encontrado = false;
        Console.Write("Placa del vehículo que sale: ");
        placa = Console.ReadLine();

        for (int i = 0; i < 10; i++)
        {
            if (vehiculos[i, 0] == placa)
            {
                vehiculos[i, 0] = "";
                vehiculos[i, 1] = "";
                vehiculos[i, 2] = "";

                Console.WriteLine("\nEl vehículo ha salido. Registro eliminado.");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("\nPlaca no encontrada.");
        }
    }

    static void Pausa()
    {
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}