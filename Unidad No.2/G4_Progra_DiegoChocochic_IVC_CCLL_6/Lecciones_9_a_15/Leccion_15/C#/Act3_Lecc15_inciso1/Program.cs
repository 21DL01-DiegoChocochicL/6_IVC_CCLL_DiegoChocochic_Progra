namespace Act3_Lecc15_inciso1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i, multiplo, suma, contPares;
            suma = 0;
            contPares = 0;

            Console.WriteLine("*******************************************");
            Console.WriteLine("      ANÁLISIS DE MÚLTIPLOS DE 7           ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Calculando los primeros 20 múltiplos de 7:");
            Console.WriteLine("-------------------------------------------");

            for (i = 1; i <= 20; i++)
            {
                multiplo = i * 7;
                Console.WriteLine("#" + i + ": " + multiplo);

                suma += multiplo;

                if (multiplo % 2 == 0)
                    contPares++;
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("RESULTADOS DEL PROCESO:");
            Console.WriteLine("La suma total es: " + suma);
            Console.WriteLine("Cantidad de múltiplos pares: " + contPares);
            Console.WriteLine("*******************************************");
        }
    }
}
