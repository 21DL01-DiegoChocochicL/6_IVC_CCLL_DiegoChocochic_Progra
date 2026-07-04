namespace Act3_Lecc10_inciso1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num, i, divisores, suma;
            suma = 0;

            Console.WriteLine("*******************************************");
            Console.WriteLine("    SUMATORIA DE NÚMEROS PRIMOS (1-22)     ");
            Console.WriteLine("*******************************************");

            for (num = 1; num <= 22; num++)
            {
                divisores = 0;

                for (i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                        divisores++;
                }

                if (divisores == 2)
                {
                    suma += num;
                    Console.WriteLine(num + " (Primo)");
                }
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("La suma total de los números primos es: " + suma);
            Console.WriteLine("*******************************************");
        }
    }
}
