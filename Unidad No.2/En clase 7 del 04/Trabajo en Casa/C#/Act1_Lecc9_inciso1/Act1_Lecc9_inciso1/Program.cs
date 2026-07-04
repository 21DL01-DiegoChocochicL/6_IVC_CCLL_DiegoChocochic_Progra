internal class Program
{
    private static void Main(string[] args)
    {
        int pesoMan = 0;
        int pesoTt = 0;
        int contadorManzanas = 0;

        while (pesoTt < 1000)
        {
            Console.WriteLine("Ingrese el peso de la manzana (en gramos): ");

            if (int.TryParse(Console.ReadLine(), out pesoMan))
            {
                if (pesoMan >= 180)
                {
                    pesoTt += pesoMan;
                    Console.WriteLine($"Peso total actual: {pesoTt}g");
                    contadorManzanas++;
                }
                else
                {
                    Console.WriteLine("Error: La manzana es muy pequeña (mínimo 180g).");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
        }

        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Se ha alcanzado o superado el límite de 1000g.");
        Console.WriteLine($"Peso final: {pesoTt}g. Total de manzanas: {contadorManzanas}.");
    }
}