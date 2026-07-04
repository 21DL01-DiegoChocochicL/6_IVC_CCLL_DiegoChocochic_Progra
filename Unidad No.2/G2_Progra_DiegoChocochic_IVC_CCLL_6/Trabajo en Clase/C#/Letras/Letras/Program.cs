internal class Program
{
    private static void Main(string[] args)
    {
        // Ingresa una letra: A = Excelente, B = Bueno, C = Regular, D = Deficiente, F = Reprobado

        // Inicio
        Console.WriteLine("\t* Menu");
        Console.WriteLine("\t**********************************************");
        Console.WriteLine("\t* Lista de Letras                            *");
        Console.WriteLine("\t* A- Excelentes                              *");
        Console.WriteLine("\t* B- Bueno                                   *");
        Console.WriteLine("\t* C- Regular                                 *");
        Console.WriteLine("\t* D- Deficiente                              *");
        Console.WriteLine("\t* F- Reprobado                               *");
        Console.WriteLine("\t**********************************************");

        Console.WriteLine("Dígame su nota (0-100):");
        int nota = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Dígame la clase:");
        string clase = Console.ReadLine();

        //Proceso
        int decena = nota / 10;

        //Salida
        Console.WriteLine("Resultado para la clase de "+ clase+ ":");

        //Sentencia de Seleccion
        switch (decena)
        {
            case 10:
            case 9:
                Console.WriteLine("A");
                break;
            case 8:
                Console.WriteLine("B");
                break;
            case 7:
                Console.WriteLine("C");
                break;
            case 6:
                Console.WriteLine("D");
                break;
            default:
                Console.WriteLine("F");
                break;
        }
    }
}