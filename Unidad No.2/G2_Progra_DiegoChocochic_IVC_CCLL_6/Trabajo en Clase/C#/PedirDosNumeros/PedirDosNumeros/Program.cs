internal class Program
{
    private static void Main(string[] args)
    {
        // Pide dos números y una opción: 1 = Sumar, 2 = Restar, 3 = Multiplicar, 4 = Dividir - Muestra el
        // resultado según la opción elegida.

        // Inicio
        Console.WriteLine("Diguite dos numeros: ");
        float num = float.Parse(Console.ReadLine());
        float num2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digame el Carcter");
        string c = Console.ReadLine();

        // Proceso , Sentencia de Seleccion y Salida
        switch (c)
        {
            case "Sumar" or "suma" or "sumar" or "+":
                Console.WriteLine("La Suma es, " + (num + num2));
                break;
            case "Resta" or "resta" or "rest"or "-":
                Console.WriteLine("La Resta es, " + (num - num2));
                break;
            case "Multiplicar" or "multiplicar" or "multi"or "*":
                Console.WriteLine("La Muliplicacion es, " + (num * num2));
                break;
            case "Dividir" or "dividir" or "/":
                Console.WriteLine("La Division es, "+ (num/num2));
                break;
            default:
                Console.WriteLine("Caracter no reconocido.");
                break;
        }
    }
}