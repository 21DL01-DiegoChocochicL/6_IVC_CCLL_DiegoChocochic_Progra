namespace Act2_Lecc10_inciso1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("        GENERADOR DE MÚLTIPLOS DE 4        ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Los primeros 20 múltiplos de 4 son:");
            Console.WriteLine("-------------------------------------------");

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i * 4);
                Console.ReadKey();
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Fin de la secuencia.");
            Console.WriteLine("*******************************************");
        }
    }
}
