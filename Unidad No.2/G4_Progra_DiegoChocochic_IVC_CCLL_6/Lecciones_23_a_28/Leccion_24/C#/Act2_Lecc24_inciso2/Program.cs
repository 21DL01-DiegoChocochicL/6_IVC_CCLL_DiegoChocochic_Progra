namespace Act2_Lecc10_inciso2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n;

            Console.WriteLine("*******************************************");
            Console.WriteLine("      GENERADOR DE SECUENCIA DE PARES      ");
            Console.WriteLine("*******************************************");
            Console.Write("Ingrese un número mayor o igual a 2: ");
            n = int.Parse(Console.ReadLine()!);

            if (n < 2)
            {
                Console.WriteLine(">> [ERROR]: El número debe ser mayor o igual a 2.");
            }
            else
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Números pares del 2 al " + n + ":");

                for (int i = 2; i <= n; i += 2)
                {
                    Console.WriteLine(i);
                    Console.ReadKey();
                }

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Secuencia completada.");
            }

            Console.WriteLine("*******************************************");
        }
    }
}
