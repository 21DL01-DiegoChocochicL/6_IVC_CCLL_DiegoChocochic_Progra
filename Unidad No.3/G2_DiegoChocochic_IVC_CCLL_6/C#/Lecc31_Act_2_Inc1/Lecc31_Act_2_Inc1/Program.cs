internal class Program
{
    private static void Main(string[] args)
    {
        //Desarrola un programa en C# para crear la matriz y asignar a cada posicion los valores que se muestran.
        //Despues de crear la matriz y asignar los valores, debes mostrar los valores en la consola. Utilizar FOR.

        //Diego Alejandro Chocochic L. IV Bach. CC.LL. Compu. "C" clave:6
        Console.WriteLine($"n/ Nombre: Diego Chocochic" + "n/Grado: IV Bach. CC.LL. Compu. C" + "n/Clave:6" + "n/Matrices");

        int[,] matriz = new int[4, 4];

        for (int fila = 0; fila < 4; fila++)
        {
            for (int col = 0; col < 4; col++)
            {
                if (fila == col)
                {
                    matriz[fila, col] = 1;
                }
                else
                {
                    matriz[fila, col] = 0;
                }
            }
        }

        Console.WriteLine("Matriz Identidad 4x4:");
        for (int fila = 0; fila < 4; fila++)
        {
            for (int col = 0; col < 4; col++)
            {
                Console.Write(matriz[fila, col] + " ");
            }
            Console.WriteLine();
        }
    }
}