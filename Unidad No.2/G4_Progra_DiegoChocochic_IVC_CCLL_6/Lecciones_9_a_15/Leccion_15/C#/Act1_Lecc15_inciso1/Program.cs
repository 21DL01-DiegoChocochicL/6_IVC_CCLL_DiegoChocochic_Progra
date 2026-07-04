namespace Act1_Lecc15_inciso1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int contBoletos = 0;
            double acumDinero = 0;
            int op = 1;

            Console.WriteLine("*******************************************");
            Console.WriteLine("   SISTEMA DE CONTROL: RUEDA DE LA FORTUNA ");
            Console.WriteLine("*******************************************");

            while (op != 0)
            {
                Console.WriteLine();
                Console.WriteLine("--- Menú de Ventas ---");
                Console.WriteLine("1. Adulto ($15)");
                Console.WriteLine("2. Niño ($10)");
                Console.WriteLine("0. Cerrar caja y ver reporte");
                Console.Write("Seleccione una opción: ");
                op = int.Parse(Console.ReadLine()!);

                switch (op)
                {
                    case 1:
                        acumDinero += 15;
                        contBoletos++;
                        Console.WriteLine(">> [ÉXITO]: Venta registrada (Adulto).");
                        break;
                    case 2:
                        acumDinero += 10;
                        contBoletos++;
                        Console.WriteLine(">> [ÉXITO]: Venta registrada (Niño).");
                        break;
                    case 0:
                        Console.WriteLine(">> [AVISO]: Cerrando sistema de ventas...");
                        break;
                    default:
                        Console.WriteLine(">> [ERROR]: Opción no válida. Intente de nuevo.");
                        break;
                }
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("           REPORTE DE CIERRE               ");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Total de boletos vendidos: " + contBoletos);
            Console.WriteLine("Total de dinero recaudado: $" + acumDinero);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Proceso finalizado.");
            Console.WriteLine("*******************************************");
        }
    }
}
