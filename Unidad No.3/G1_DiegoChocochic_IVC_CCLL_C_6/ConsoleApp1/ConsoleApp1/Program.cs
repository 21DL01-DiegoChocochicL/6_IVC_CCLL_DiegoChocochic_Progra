internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matriz = new int[2, 3] {
            { 5, 8, 2 },
            { 1, 4, 7 }
        };

        // Bucles para recorrer y mostrar la matriz
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine(); // Salto de línea al terminar cada fila
        }
    }
}