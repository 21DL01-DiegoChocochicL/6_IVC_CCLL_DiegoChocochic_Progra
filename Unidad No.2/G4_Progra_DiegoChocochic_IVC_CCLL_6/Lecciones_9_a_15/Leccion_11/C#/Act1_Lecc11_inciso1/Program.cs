namespace Act1_Lecc11_inciso1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int capacidad = 200;
            int autosActuales = 0;
            int opcion;

            Console.WriteLine("*******************************************");
            Console.WriteLine("    SISTEMA DE GESTIÓN DE ESTACIONAMIENTO   ");
            Console.WriteLine("*******************************************");

            do
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Cajones disponibles: " + (capacidad - autosActuales));
                Console.Write("Ingrese 1 para estacionar un auto (o cualquier otro número para salir): ");
                opcion = int.Parse(Console.ReadLine()!);

                if (opcion == 1)
                {
                    if (autosActuales < capacidad)
                    {
                        autosActuales++;
                        Console.WriteLine(">> [ÉXITO]: Auto estacionado con éxito.");
                    }
                    else
                    {
                        Console.WriteLine(">> [ERROR]: ¡El estacionamiento está lleno!");
                    }
                }
                else
                {
                    Console.WriteLine(">> [AVISO]: Saliendo del sistema...");
                }

            } while (opcion == 1 && autosActuales != capacidad);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Programa finalizado.");
            Console.WriteLine("*******************************************");
        }
    }
}
