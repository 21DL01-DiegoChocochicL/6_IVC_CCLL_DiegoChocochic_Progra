internal class Program
{
    private static void Main(string[] args)
    {
        // Elabore un conversor de medidas de longitud. El usuario podrá elegir entre las siguientes unidades de
        // medida: - a) Metros - b) Pies - c) Centímetros - d) Pulgadas
        
        // Inicio
        Console.WriteLine("\t* Menu");
        Console.WriteLine("\t**********************************************");
        Console.WriteLine("\t* Lista de Unidades de Medida              *");
        Console.WriteLine("\t* a- Metros                                *");
        Console.WriteLine("\t* b- Pies                                  *");
        Console.WriteLine("\t* c- Centímetros                           *");
        Console.WriteLine("\t* d- Pulgadas                              *");
        Console.WriteLine("\t**********************************************");

        Console.Write("Digame un numero: ");
        double n  = double.Parse(Console.ReadLine());
        Console.WriteLine("Seleccione una media del Menu: ");
        string m = Console.ReadLine();

        // Sentencia de Seleccion, Proceso y Salida
        switch (m)
        {
            case "a":
            case "A":
                Console.WriteLine("La conversion es, "+ n + " Metros");
                break;
            case "b":
            case "B":
                Console.WriteLine("La conversion es, " + n + " Pies");
                break;
            case "c":
            case "C":
                Console.WriteLine("La conversion es, " + n + " Centimetros");
                break;
            case "d":
            case "D":
                Console.WriteLine("La conversion es, " + n + " Pulgadas");
                break;
            default:
                Console.WriteLine("Numero no Valido");
                break;
        }
    }
}