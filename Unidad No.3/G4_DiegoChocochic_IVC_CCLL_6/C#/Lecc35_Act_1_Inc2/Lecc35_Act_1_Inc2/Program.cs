internal class Program
{
    private static void Main(string[] args)
    {
        //En una tienda, el cajero ingresa el precio de un producto y despues la denominacion del billete con que pago el cliente
        //El programa muestra cuantos billetes de 200,100,5.,20 y monedas se deben dar de cambio
        Console.WriteLine("Nombre:Diego Alejandro Chocochic L.\n" + "Grado:IV Bach. CC.LL\n" + "Seccion:C\n" + "Calve:6\n"
        + "Calculadora de cambio\n" + "");

        Console.WriteLine("--- Calculadora de Cambio ---");

        Console.Write("Ingrese el precio del producto: ");
        double precio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la denominación del billete con que pagó el cliente: ");
        double pago = Convert.ToDouble(Console.ReadLine());

        if (pago < precio)
        {
            Console.WriteLine("Error: El pago es insuficiente para cubrir el precio del producto.");
            return;
        }

        double cambioTotal = pago - precio;
        Console.WriteLine($"\nEl cambio total a entregar es: ${cambioTotal:F2}");

        int cambioEntero = (int)cambioTotal;
        double monedas = cambioTotal - cambioEntero;

        int[] billetes = { 200, 100, 50, 20 };

        Console.WriteLine("\nDesglose de cambio:");

        foreach (int denominacion in billetes)
        {
            int cantidadBilletes = cambioEntero / denominacion;
            cambioEntero %= denominacion; 

            if (cantidadBilletes > 0)
            {
                Console.WriteLine($"- Billetes de ${denominacion}: {cantidadBilletes}");
            }
        }

        double totalMonedas = cambioEntero + monedas;
        if (totalMonedas > 0)
        {
            Console.WriteLine($"- En monedas: ${totalMonedas:F2}");
        }
    }
}