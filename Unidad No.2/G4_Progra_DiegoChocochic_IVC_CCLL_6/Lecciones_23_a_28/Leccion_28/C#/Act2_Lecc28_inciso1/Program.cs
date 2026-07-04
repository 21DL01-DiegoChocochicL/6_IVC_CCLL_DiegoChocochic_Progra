namespace Act2_Lecc15_inciso1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num, i, divisores, contPrimos, sumaPrimos;
            contPrimos = 0;
            sumaPrimos = 0;

            Console.WriteLine("*******************************************");
            Console.WriteLine("      ANÁLISIS DE NÚMEROS PRIMOS (1-100)   ");
            Console.WriteLine("*******************************************");

            for (num = 1; num <= 100; num++)
            {
                divisores = 0;

                for (i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                        divisores++;
                }

                if (divisores == 2)
                {
                    contPrimos++;
                    sumaPrimos += num;
                }
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Cantidad de números primos: " + contPrimos);
            Console.WriteLine("Suma de los números primos: " + sumaPrimos);
            Console.WriteLine("*******************************************");
        }
    }
}
