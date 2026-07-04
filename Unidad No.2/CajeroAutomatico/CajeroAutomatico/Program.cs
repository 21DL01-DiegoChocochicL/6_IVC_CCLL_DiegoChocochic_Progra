internal class Program
{
    private static void Main(string[] args)
    {
        int saldo = 1000;
        int PinC = 1234;
        int Intentos = 0;

        Console.WriteLine("=========================================");
        Console.WriteLine("       SISTEMA DE CAJERO VIRTUAL         ");
        Console.WriteLine("=========================================");

        while (Intentos < 3)
        {
            Console.WriteLine("");
            Console.WriteLine(">> Ingresa tu PIN de seguridad:");
            int pin = Convert.ToInt32(Console.ReadLine());

            if (pin == PinC)
            {
                Console.WriteLine("");
                Console.WriteLine("*****************************************");
                Console.WriteLine("    ACCESO CONCEDIDO - BIENVENIDO/A      ");
                Console.WriteLine("*****************************************");

                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("---------- MENÚ DE OPERACIONES ----------");
                    Console.WriteLine("  1. Consultar saldo");
                    Console.WriteLine("  2. Depositar dinero");
                    Console.WriteLine("  3. Retirar dinero");
                    Console.WriteLine("  4. Salir del sistema");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine(">> Selecciona una opción:");
                    int op = Convert.ToInt32(Console.ReadLine());

                    switch (op) { 
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine(">> Tu saldo actual es: Q" + saldo);
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine(">> Ingresa el monto a depositar:");
                        int deposito = Convert.ToInt32(Console.ReadLine());
                        if (deposito > 0)
                        {
                            saldo += deposito;
                            Console.WriteLine(">> Depósito exitoso. Nuevo saldo: $" + saldo);
                        }
                        else
                        {
                            Console.WriteLine(">> Monto inválido. El depósito debe ser mayor a cero.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine(">> Ingresa el monto a retirar:");
                        int retiro = Convert.ToInt32(Console.ReadLine());
                        if (retiro > 0 && retiro <= saldo)
                        {
                            saldo -= retiro;
                            Console.WriteLine(">> Retiro exitoso. Nuevo saldo: $" + saldo);
                        }
                        else
                        {
                            Console.WriteLine(">> Monto inválido o saldo insuficiente.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("*****************************************");
                        Console.WriteLine("    GRACIAS POR USAR EL CAJERO VIRTUAL   ");
                        Console.WriteLine("*****************************************");
                        return;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine(">> Opción no válida. Por favor, selecciona una opción del menú.");
                        break;
                    }
                while (op == 4) ;
                Intentos = 5;
                }


            else
            {
                Intentos++;
                Console.WriteLine("");
                Console.WriteLine(">> PIN incorrecto. Intento " + Intentos + " de 3.");
              
                if (Intentos == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine("   BLOQUEO DE SEGURIDAD ACTIVADO         ");
                    Console.WriteLine("   Demasiados intentos fallidos.         ");
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine("El sistema se cerrará en 5s...");

                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("=========================================");
                    Console.WriteLine("   GRACIAS POR USAR NUESTROS SERVICIOS   ");
                    Console.WriteLine("=========================================");

                }
            }
        }
    }
}