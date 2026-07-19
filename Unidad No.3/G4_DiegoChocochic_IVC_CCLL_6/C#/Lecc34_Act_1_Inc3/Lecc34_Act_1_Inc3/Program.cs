internal class Program
{
    private static void Main(string[] args)
    {
        //Recibe una cantidad en grados centigrados y la convierte a: a.Fahrenheit;b.Celcius;c.Kelvin
        Console.WriteLine("Nombre:Diego Alejandro Chocochic L.\n" + "Grado:IV Bach. CC.LL\n" + "Seccion:C\n" + "Calve:6\n"
        + "Conversiones de Centigrados\n" + "");

        Console.Write("Ingrese la cantidad en grados centígrados (°C): ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nConvertir a:");
        Console.WriteLine("a. Fahrenheit");
        Console.WriteLine("b. Celsius (Misma escala)");
        Console.WriteLine("c. Kelvin");
        Console.Write("Seleccione una opción (a-c): ");
        string opcion = Console.ReadLine().ToLower();

        double resultado = 0;
        string unidad = "";

        switch (opcion)
        {
            case "a":
                resultado = (celsius * 9.0 / 5.0) + 32;
                unidad = "grados Fahrenheit (°F)";
                break;
            case "b":
                resultado = celsius;
                unidad = "grados Celsius (°C)";
                break;
            case "c":
                resultado = celsius + 273.15;
                unidad = "Kelvin (K)";
                break;
            default:
                Console.WriteLine("Opción no válida.");
                return;
        }

        Console.WriteLine($"\n{celsius} grados centígrados equivale a {resultado:F2} {unidad}.");
    }
}