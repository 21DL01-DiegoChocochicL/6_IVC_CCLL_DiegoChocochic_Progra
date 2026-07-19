internal class Program
{
    private static void Main(string[] args)
    {
        //Crea un nuevo programa en C# que reciba una cantidad en metros y muestre un menu de opciones, el cual
        //pregunte si quiere convertir a: mm,cm,dcm,hcm,klm
        Console.WriteLine("Nombre:Diego Alejandro Chocochic L.\n"+"Grado:IV Bach. CC.LL\n"+"Seccion:C\n"+"Calve:6\n"
            +"Conversiones\n"+"");

        Console.Write("Ingrese la cantidad en metros: ");
        double metros = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nMenú de opciones. Convertir a:");
        Console.WriteLine("a. Milímetros");
        Console.WriteLine("b. Centímetros");
        Console.WriteLine("c. Decímetros");
        Console.WriteLine("d. Hectómetros");
        Console.WriteLine("e. Kilómetros");
        Console.Write("Seleccione una opción: ");
        string opcion = Console.ReadLine().ToLower();

        double resultado = 0;
        string unidad = "";

        switch (opcion)
        {
            case "a":
                resultado = metros * 1000;
                unidad = "milímetros";
                break;
            case "b":
                resultado = metros * 100;
                unidad = "centímetros";
                break;
            case "c":
                resultado = metros * 10;
                unidad = "decímetros";
                break;
            case "d":
                resultado = metros / 100;
                unidad = "hectómetros";
                break;
            case "e":
                resultado = metros / 1000;
                unidad = "kilómetros";
                break;
            default:
                Console.WriteLine("Opción no válida.");
                return;
        }

        Console.WriteLine($"\n{metros} metros equivale a {resultado} {unidad}.");
    }
}
