using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        int n, acumulador;

        Console.WriteLine("==========================================");
        Console.WriteLine("        BIENVENIDO AL CALCULADOR          ");
        Console.WriteLine("         DE CUENTAS REGRESIVAS            ");
        Console.WriteLine("==========================================");
        Console.WriteLine();

        Console.WriteLine("  > Por favor, ingresa un número entero positivo:");

        if (int.TryParse(Console.ReadLine(), out n))
        {
            if (n <= 0)
            {
                Console.WriteLine("  [!] Error: El número debe ser mayor a 0.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("--- Iniciando secuencia ---");
                Console.WriteLine();

                acumulador = 0;

                for (int i = n; i >= 1; i--)
                {
                    if (i == 1)
                    {
                        Console.WriteLine(i + ".");
                    }
                    else
                    {
                        Console.Write(i + ", ");
                    }

                    acumulador += i;
                }

                Console.WriteLine();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("  RESULTADO FINAL:");
                Console.WriteLine("  La suma total de la secuencia es: " + acumulador);
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("          ¡Gracias por usarme!            ");
            }
        }
        else
        {
            Console.WriteLine("  [!] Error: Ingresa un valor numérico válido.");
        }

        Console.WriteLine("\nPresiona cualquier tecla para finalizar...");
        Console.ReadKey();
    }
}