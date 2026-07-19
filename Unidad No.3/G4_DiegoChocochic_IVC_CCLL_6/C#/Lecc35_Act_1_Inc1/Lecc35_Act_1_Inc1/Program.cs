internal class Program
{
    private static void Main(string[] args)
    {
        //Se ingresa una cantidad en la moneda local y el programa muestra el equivalente en la moneda de cinco distintos
        //paises de tu eleccion.Al teminar, el programa debe preguntar si desea convertir otra cantidad.
        Console.WriteLine("Nombre:Diego Alejandro Chocochic L.\n" + "Grado:IV Bach. CC.LL\n" + "Seccion:C\n" + "Calve:6\n"
        + "Convertidor de monedas\n" + "");

        bool calcularOtraVez = true;

        Console.WriteLine("========================================");
        Console.WriteLine("      Conversor de Moneda Múltiple      ");
        Console.WriteLine("========================================");

        while (calcularOtraVez)
        {
            Console.Write("\nIngrese la cantidad en moneda local (MXN): $");
            double monedaLocal = Convert.ToDouble(Console.ReadLine());

            if (monedaLocal < 0)
            {
                Console.WriteLine("Por favor, ingrese una cantidad válida mayor o igual a cero.");
                continue;
            }

            double tasaUSD = 0.050; 
            double tasaEUR = 0.046; 
            double tasaGTQ = 0.39;  
            double tasaJPY = 7.55;  
            double tasaGBP = 0.039; 

            Console.WriteLine("\n--- Equivalencias ---");
            Console.WriteLine($"- Estados Unidos (USD): ${(monedaLocal * tasaUSD):F2}");
            Console.WriteLine($"- Unión Europea (EUR): €{(monedaLocal * tasaEUR):F2}");
            Console.WriteLine($"- Guatemala (GTQ): Q{(monedaLocal * tasaGTQ):F2}");
            Console.WriteLine($"- Japón (JPY): ¥{(monedaLocal * tasaJPY):F2}");
            Console.WriteLine($"- Reino Unido (GBP): £{(monedaLocal * tasaGBP):F2}");

            Console.Write("\n¿Desea convertir otra cantidad? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta != "s")
            {
                calcularOtraVez = false;
            }
        }

        Console.WriteLine("\nCerrando Programa");
    }
}