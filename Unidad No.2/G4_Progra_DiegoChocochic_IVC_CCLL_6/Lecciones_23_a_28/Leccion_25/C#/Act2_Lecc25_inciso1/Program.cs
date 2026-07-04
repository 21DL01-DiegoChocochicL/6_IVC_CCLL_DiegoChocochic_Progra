namespace Act2_Lecc11_inciso1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n, factorial, temp;

            Console.WriteLine("*******************************************");
            Console.WriteLine("         CALCULADORA DE FACTORIAL          ");
            Console.WriteLine("*******************************************");
            Console.Write("Ingrese un número para calcular su factorial: ");
            n = int.Parse(Console.ReadLine()!);

            factorial = 1;
            temp = n;

            if (n == 0 || n == 1)
            {
                Console.WriteLine("Resultado: El factorial de " + n + " es 1");
            }
            else
            {
                do
                {
                    factorial *= temp;
                    temp--;
                } while (temp != 1);

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Resultado: El factorial de " + n + " es " + factorial);
            }

            Console.WriteLine("*******************************************");
        }
    }
}
