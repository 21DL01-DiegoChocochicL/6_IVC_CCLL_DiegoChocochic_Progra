namespace Act1_Lecc10_inciso1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("         PROGRAMA DE FIDELIDAD             ");
            Console.WriteLine("*******************************************");

            for (int corte = 1; corte <= 8; corte++)
            {
                Console.WriteLine("Visita No. " + corte + ": Has recibido un sello.");
                Console.ReadKey();
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("¡Felicidades! Tienes 8 sellos.");
            Console.WriteLine("Tu próximo corte es gratis.");
            Console.WriteLine("*******************************************");
        }
    }
}
