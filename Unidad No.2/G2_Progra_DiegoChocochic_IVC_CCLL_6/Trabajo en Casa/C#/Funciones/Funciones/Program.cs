using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        // Crear una calculadora de funciones trigonométricas, dado un ángulo ingresado por el usuario (en grados)
        // se debe calcular a una de las 3 funciones trigonométricas básicas.

        // Inicio
        Console.WriteLine("\t* CALCULADORA FUNCIONES TRIGONOMETRICAS BASICAS");
        Console.WriteLine("\t**********************************************");
        Console.WriteLine("\t* Lista de funciones trigonometricas         *");
        Console.WriteLine("\t* 1- Seno                                    *");
        Console.WriteLine("\t* 2- Coseno                                  *");
        Console.WriteLine("\t* 3- Tangente                                *");
        Console.WriteLine("\t**********************************************");

        Console.Write("Ingresa el angulo: ");
        double g = double.Parse(Console.ReadLine());

        Console.WriteLine("Selecciona una funcion: ");
        int op = int.Parse(Console.ReadLine());

        //Proceso
        double r =g * (Math.PI / 180);

        // Sentencia de Seleccion, Proceso y Salida
        switch (op)
        {
            case 1:
                double resSeno = Math.Sin(r);
                Console.WriteLine("El Seno de " + g + " grados es: " + resSeno);
                break;
            case 2:
                double resCos = Math.Cos(r);
                Console.WriteLine("El Coseno de " + g + " grados es: " + resCos);
                break;
            case 3:
                if (Math.Abs(Math.Cos(r)) < 0.000001)
                {
                    Console.WriteLine("Error: La tangente no esta definida para este angulo.");
                }
                else
                {
                    double resTan= Math.Tan(r); 
                    Console.WriteLine("La Tangente de "+ g +" grados es: "+ resTan);
                }
                break;
                default:
                Console.WriteLine("Opcion no valida.");
                break;
        }
    }
}