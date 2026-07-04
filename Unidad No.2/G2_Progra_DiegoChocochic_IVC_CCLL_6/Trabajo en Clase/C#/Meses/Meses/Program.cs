internal class Program
{
    private static void Main(string[] args)
    {
        // Pide un número del 1 al 12 y muestra el mes correspondiente, Indica también cuántos días tiene el
        // mes

        // Inicio
        Console.WriteLine("\t* Menu");
        Console.WriteLine("\t**********************************************");
        Console.WriteLine("\t* Lista de Meses del Año                     *");
        Console.WriteLine("\t* 1- Enero                                   *");
        Console.WriteLine("\t* 2- Febrero                                 *");
        Console.WriteLine("\t* 3- Marzo                                   *");
        Console.WriteLine("\t* 4- Abril                                   *");
        Console.WriteLine("\t* 5- Mayo                                    *");
        Console.WriteLine("\t* 6- Junio                                   *");
        Console.WriteLine("\t* 7- Julio                                   *");
        Console.WriteLine("\t* 8- Agosto                                  *");
        Console.WriteLine("\t* 9- Septiembre                              *");
        Console.WriteLine("\t* 10- Octubre                                *");
        Console.WriteLine("\t* 11- Noviembre                              *");
        Console.WriteLine("\t* 12- Diciembre                              *");
        Console.WriteLine("\t**********************************************");

        Console.Write("Digame un numero del 1 al 12 para saber cuantos días tiene: ");
        int num = int.Parse(Console.ReadLine());

        // Proceso, Salida y Sentencia Seleccion
        switch (num)
        {
            case 1: 
                Console.WriteLine("Enero: 31 días");
                break;
            case 2:
                Console.WriteLine("Febrero: 28 días (29 días en año bisiesto)");
                break;
            case 3:
                Console.WriteLine("Marzo: 31 días");
                break;
            case 4:
                Console.WriteLine("Abril: 30 días");
                break;
            case 5:
                Console.WriteLine("Mayo: 31 días");
                break;
            case 6:
                Console.WriteLine("Junio: 30 días");
                break;
            case 7:
                Console.WriteLine("Julio: 31 días");
                break;
            case 8:
                Console.WriteLine("Agosto: 31 días");
                break;
            case 9:
                Console.WriteLine("Septiembre: 30 días");
                break;
            case 10:
                Console.WriteLine("Octubre: 31 días");
                break;
            case 11:
                Console.WriteLine("Noviembre: 30 días");
                break;
            case 12:
                Console.WriteLine("Diciembre: 31 días");
                break;
            default:
                Console.WriteLine("Numero no Valido");
                break;
        }
    }
}