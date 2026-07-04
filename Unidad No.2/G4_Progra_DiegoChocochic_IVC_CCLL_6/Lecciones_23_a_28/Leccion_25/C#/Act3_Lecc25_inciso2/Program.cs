namespace Act3_Lecc11_inciso2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num, suma;
            suma = 0;

            Console.WriteLine("*******************************************");
            Console.WriteLine("         SUMADOR DE VALORES LIBRES         ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Ingrese los números que desea sumar.");
            Console.WriteLine(">> (Ingrese el número 9 para terminar y ver el total):");
            Console.WriteLine("-------------------------------------------");

            do
            {
                num = int.Parse(Console.ReadLine()!);

                if (num != 9)
                {
                    suma += num;
                    Console.WriteLine("  + Valor acumulado: " + suma);
                }
            } while (num != 9);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("¡Proceso finalizado!");
            Console.WriteLine("La suma total es: " + suma);
            Console.WriteLine("*******************************************");
        }
    }
}
