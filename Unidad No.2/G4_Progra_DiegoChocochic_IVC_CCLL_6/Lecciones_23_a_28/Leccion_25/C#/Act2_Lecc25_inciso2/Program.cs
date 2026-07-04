namespace Act2_Lecc11_inciso2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i = 1;

            Console.WriteLine("*******************************************");
            Console.WriteLine("       GENERADOR DE NÚMEROS IMPARES        ");
            Console.WriteLine("*******************************************");

            do
            {
                Console.WriteLine(i);
                i += 2;
            } while (i <= 100);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Proceso finalizado: secuencia completada.");
            Console.WriteLine("*******************************************");
        }
    }
}
