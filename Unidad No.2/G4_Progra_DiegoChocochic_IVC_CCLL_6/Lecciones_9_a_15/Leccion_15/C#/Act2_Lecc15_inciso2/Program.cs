namespace Act2_Lecc15_inciso2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int denominacion, cont100, suma100, i;
            cont100 = 0;
            suma100 = 0;
            i = 1;

            Console.WriteLine("*******************************************");
            Console.WriteLine("       CONTADOR DE BILLETES DE $100        ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Nota: Ingrese 0 en cualquier momento para terminar.");

            while (i <= 1000)
            {
                Console.WriteLine("-------------------------------------------");
                Console.Write("Billete #" + i + " (Ingrese 20, 50, 100, o 0 para salir): ");
                denominacion = int.Parse(Console.ReadLine()!);

                if (denominacion == 0)
                {
                    Console.WriteLine(">> [AVISO]: Proceso cancelado por el usuario.");
                    i = 1001;
                }
                else
                {
                    if (denominacion == 100)
                    {
                        cont100++;
                        suma100 += 100;
                        Console.WriteLine(">> [ÉXITO]: Billete de $100 registrado.");
                    }
                    else
                    {
                        Console.WriteLine(">> [INFO]: Billete registrado (distinto a $100).");
                    }
                    i++;
                }
            }

            Console.WriteLine("*******************************************");
            Console.WriteLine("             REPORTE FINAL                 ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Total de billetes de $100: " + cont100);
            Console.WriteLine("Total de dinero en billetes de $100: $" + suma100);
            Console.WriteLine("*******************************************");
        }
    }
}
