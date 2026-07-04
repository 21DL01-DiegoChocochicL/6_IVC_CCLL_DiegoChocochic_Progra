internal class Program
{
    private static void Main(string[] args)
    {
        //Inicio
        double precio_sin_iva = 650.00;
        double precio_con_iva = precio_sin_iva * 1.12;
        double porc_desc = 0.00;
        String forma_pago = "";

        Console.WriteLine("--- SISTEMA DE VENTAS DE IMPRESORES ---");
        Console.Write("Cantidad de impresoras a comprar: ");
        int cantidad = int.Parse(Console.ReadLine());

        Console.WriteLine("\t* Menu");
        Console.WriteLine("\t**********************************************");
        Console.WriteLine("\t* Seleccione la forma de pago:              *");
        Console.WriteLine("\t* 1. Efectivo (10% desc)                    *");
        Console.WriteLine("\t* 2. Tarjeta de credito (5% desc)           *");
        Console.WriteLine("\t* 3. Vale de regalo (15% desc)              *");
        Console.WriteLine("\t**********************************************");

        Console.Write("Ingrese su opcion: ");
        int opcion_pago = int.Parse(Console.ReadLine());

        //Sentencia de Seleccion
        switch (opcion_pago)
        {
            case 1:
                porc_desc = 0.10;
                forma_pago = "Efectivo";
                break;
            case 2:
                porc_desc = 0.05;
                forma_pago = "Tarjeta de credito";
                break;
            case 3:
                porc_desc = 0.15;
                forma_pago = "Vale de regalo";
                break;
            default:
                porc_desc = 0.00;
                forma_pago = "No valida (Sin descuento)";
                break;
        }

        //Proceso
        double total_sin_desc = precio_con_iva * cantidad;
        double descuento = total_sin_desc * porc_desc;
        double total_pagar = total_sin_desc - descuento;

        //Salida
        Console.WriteLine("========================================");
        Console.WriteLine("           Detalles de Pago             ");
        Console.WriteLine("========================================");
        Console.WriteLine("Cantidad comprada:          " + cantidad);
        Console.WriteLine("Precio unitario (con IVA):  Q" + precio_con_iva);
        Console.WriteLine("Total sin descuento:        Q" + total_sin_desc);
        Console.WriteLine("Forma de pago elegida:      " + forma_pago);
        Console.WriteLine("Descuento realizado:        -Q" + descuento);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("TOTAL A PAGAR:              Q" + total_pagar);
        Console.WriteLine("========================================");
    }
}