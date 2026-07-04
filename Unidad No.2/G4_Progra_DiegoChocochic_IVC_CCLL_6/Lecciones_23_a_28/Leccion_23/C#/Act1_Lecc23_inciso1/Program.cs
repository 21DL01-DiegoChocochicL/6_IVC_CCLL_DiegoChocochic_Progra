namespace Act1_Lecc9_inciso1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int pesoMan, pesoTt, contadorManzanas;

            pesoTt = 0;
            contadorManzanas = 0;

            Console.WriteLine("*******************************************");
            Console.WriteLine("      CONTROL DE PESO DE MANZANAS          ");
            Console.WriteLine("*******************************************");

            while (pesoTt < 1000)
            {
                Console.Write("Ingrese el peso de la manzana (en gramos): ");
                pesoMan = int.Parse(Console.ReadLine()!);

                if (pesoMan >= 180)
                {
                    pesoTt += pesoMan;
                    Console.WriteLine("Peso total actual: " + pesoTt + "g");
                    contadorManzanas++;
                }
                else
                {
                    Console.WriteLine("Error: La manzana es muy pequeña (mínimo 180g).");
                }
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Se ha alcanzado o superado el límite de 1000g.");
            Console.WriteLine("Peso final: " + pesoTt + "g. Total de manzanas: " + contadorManzanas + ".");
            Console.WriteLine("*******************************************");
        }
    }
}
