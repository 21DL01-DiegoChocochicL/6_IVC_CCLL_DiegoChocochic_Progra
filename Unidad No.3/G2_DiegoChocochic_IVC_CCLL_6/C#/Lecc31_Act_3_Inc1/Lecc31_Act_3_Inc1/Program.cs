internal class Program
{
    private static void Main(string[] args)
    {
        //En un salon de clases, los alumnos estan sentados en una matriz de 3 x3, como se muestran en la imahen, uno a uno, el profesor va preguntando
        //la edad de cada estudiante e ingresa este dato en un programa. Al final, el programma muestra la edad y si el alumno es mayor de edad
        //Diego Alejandro Chocochic L. IV Bach. CC.LL. Compu. "C" clave:6

        Console.WriteLine($"n/ Nombre: Diego Chocochic" + "n/Grado: IV Bach. CC.LL. Compu. C" + "n/Clave:6" + "n/Salon de Clases");
        string[,] matrizAlumnos = new string[3, 3];

        Console.WriteLine("--- Registro de Edades de los Alumnos (Matriz 3x3) ---");

        for (int fila = 0; fila < 3; fila++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write($"Ingrese la edad del alumno en la posicion [{fila+1},{col+1}]: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad >= 18)
                {
                    matrizAlumnos[fila, col] = $"{edad} - mayor";
                }
                else
                {
                    matrizAlumnos[fila, col] = $"{edad} - menor";
                }
            }
        }

        Console.WriteLine("\n--- Matriz de Resultados Final ---");
        for (int fila = 0; fila < 3; fila++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(matrizAlumnos[fila, col] + "\t| ");
            }
            Console.WriteLine();
        }
    }
}