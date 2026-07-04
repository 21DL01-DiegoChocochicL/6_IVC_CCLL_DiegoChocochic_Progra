internal class Program
{
    private static void Main(string[] args)
    {
        // Solicita un número del 1 al 7 y muestra el día correspondiente.

        // Inicio
        Console.WriteLine("\t* Menu");
        Console.WriteLine("\t**********************************************");
        Console.WriteLine("\t* Lista de Días de la Semana                 *");
        Console.WriteLine("\t* 1- Lunes                                   *");
        Console.WriteLine("\t* 2- Martes                                  *");
        Console.WriteLine("\t* 3- Miércoles                               *");
        Console.WriteLine("\t* 4- Jueves                                  *");
        Console.WriteLine("\t* 5- Viernes                                 *");
        Console.WriteLine("\t* 6- Sábado                                  *");
        Console.WriteLine("\t* 7- Domingo                                 *");
        Console.WriteLine("\t**********************************************");

        Console.WriteLine("Digame le dia de la semana en numero (1-7):");
        int dia = Convert.ToInt32(Console.ReadLine());

        // Sentencia de Selección y Salida
        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miercoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sabado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Numero no valido");
                break;
        }
    }
}
