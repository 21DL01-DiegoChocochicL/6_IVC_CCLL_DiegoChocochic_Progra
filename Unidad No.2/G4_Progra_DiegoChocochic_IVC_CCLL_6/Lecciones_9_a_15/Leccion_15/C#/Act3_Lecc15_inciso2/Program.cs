namespace Act3_Lecc15_inciso2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num, i, divisores, contPrimos, sumaPares, j;
            contPrimos = 0;
            sumaPares = 0;

            Console.WriteLine("*******************************************");
            Console.WriteLine("   ANÁLISIS MATEMÁTICO: PRIMOS Y PARES     ");
            Console.WriteLine("*******************************************");

            for (num = 300; num >= 1; num--)
            {
                divisores = 0;

                for (i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                        divisores++;
                }

                if (divisores == 2)
                    contPrimos++;
            }

            for (j = 1; j <= 300; j++)
            {
                if (j % 2 == 0)
                    sumaPares += j;
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Cantidad de números primos (300 a 1): " + contPrimos);
            Console.WriteLine("Suma de los números pares (1 a 300): " + sumaPares);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("*******************************************");
        }
    }
}
