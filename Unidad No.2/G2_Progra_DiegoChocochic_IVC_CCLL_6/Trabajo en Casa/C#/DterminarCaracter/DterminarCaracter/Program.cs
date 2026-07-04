internal class Program
{
    private static void Main(string[] args)
    {
        // El siguiente programa determina si un carácter ingresado por el usuario es vocal, digito o ninguno de
        // los anteriores.

        // Inicio
        Console.WriteLine("Escriba un caracter: ");
        string c = Console.ReadLine();

        // Sentencia de Seleccion, Proceso y Salida
        switch (c)
        {
            case "a":
            case "e":
            case "i":
            case "o":
            case "u":
                Console.WriteLine("El carácter ingresado es una vocal.");
                break;
            case "0":
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6": 
            case "7":
            case "8":
            case "9":
                Console.WriteLine("El carácter ingresado es un digito.");
                break;
            default:
                Console.WriteLine("El carácter no es ni vocal ni dígito.");
                break;
        }
    }
}