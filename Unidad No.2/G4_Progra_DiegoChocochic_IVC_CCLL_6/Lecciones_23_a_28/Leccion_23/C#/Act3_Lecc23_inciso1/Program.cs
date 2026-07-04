namespace Act3_Lecc9_inciso1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n, i;

            Console.WriteLine("*******************************************");
            Console.WriteLine("      GENERADOR DE SECUENCIA NUMÉRICA      ");
            Console.WriteLine("*******************************************");
            Console.Write("Ingrese un número mayor a 20: ");
            n = int.Parse(Console.ReadLine()!);

            if (n < 20)
            {
                Console.WriteLine(">> [ERROR]: El número debe ser mayor a 20.");
            }
            else
            {
                i = 21;
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Secuencia generada:");

                while (i <= n)
                {
                    Console.WriteLine(i);
                    i += 2;
                }

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Proceso finalizado.");
            }
        }
    }
}
