namespace Act3_Lecc9_inciso2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n, i;
            bool esPrimo;

            Console.WriteLine("*******************************************");
            Console.WriteLine("        VERIFICADOR DE NÚMEROS PRIMOS      ");
            Console.WriteLine("*******************************************");
            Console.Write("Ingrese un número entero: ");
            n = int.Parse(Console.ReadLine()!);

            esPrimo = true;
            i = 2;

            if (n <= 1)
            {
                esPrimo = false;
            }
            else
            {
                while (i <= (int)Math.Sqrt(n) && esPrimo)
                {
                    if (n % i == 0)
                        esPrimo = false;
                    i++;
                }
            }

            Console.WriteLine("-------------------------------------------");
            if (esPrimo)
                Console.WriteLine("Resultado: " + n + " ES un número primo.");
            else
                Console.WriteLine("Resultado: " + n + " NO es un número primo.");
            Console.WriteLine("*******************************************");
        }
    }
}
