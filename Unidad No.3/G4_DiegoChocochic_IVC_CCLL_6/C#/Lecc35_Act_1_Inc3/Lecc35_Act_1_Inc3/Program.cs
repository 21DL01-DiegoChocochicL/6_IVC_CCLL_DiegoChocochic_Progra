internal class Program
{
    private static void Main(string[] args)
    {
        //El usuario elige una opcion (piedra, papel o tijeras) y el programa elige al azar su opcion. El programa muestra 
        //que eligio la computadora y quien es el ganador. Al final se invita al usuario a jugar de nuevo
        Console.WriteLine("Nombre:Diego Alejandro Chocochic L.\n" + "Grado:IV Bach. CC.LL\n" + "Seccion:C\n" + "Calve:6\n"
        + "Piedra, papel o tijeras\n" + "");

        Random random = new Random();
        bool jugarDeNuevo = true;

        Console.WriteLine("========================================");
        Console.WriteLine("    ¡Juego de Piedra, Papel o Tijeras! ");
        Console.WriteLine("========================================");

        while (jugarDeNuevo)
        {
            Console.WriteLine("\nElige tu opción:");
            Console.WriteLine("1. Piedra");
            Console.WriteLine("2. Papel");
            Console.WriteLine("3. Tijeras");
            Console.Write("Tu elección (1-3): ");

            int eleccionUsuario = Convert.ToInt32(Console.ReadLine());

            if (eleccionUsuario < 1 || eleccionUsuario > 3)
            {
                Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                continue;
            }

            int eleccionCPU = random.Next(1, 4);

            string stringUsuario = ObtenerNombreOpcion(eleccionUsuario);
            string stringCPU = ObtenerNombreOpcion(eleccionCPU);

            Console.WriteLine($"\nTú elegiste: {stringUsuario}");
            Console.WriteLine($"La computadora eligió: {stringCPU}");

            if (eleccionUsuario == eleccionCPU)
            {
                Console.WriteLine("Empate");
            }
            else if ((eleccionUsuario == 1 && eleccionCPU == 3) ||
                     (eleccionUsuario == 2 && eleccionCPU == 1) ||
                     (eleccionUsuario == 3 && eleccionCPU == 2))
            {
                Console.WriteLine("¡Felicidades, ganaste!");
            }
            else
            {
                Console.WriteLine("La computadora gana.");
            }

            Console.Write("\n¿Quieres jugar de nuevo? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta != "s")
            {
                jugarDeNuevo = false;
            }
        }

        Console.WriteLine("\nGracias por jugar");
    }

    static string ObtenerNombreOpcion(int opcion)
    {
        switch (opcion)
        {
            case 1: return "Piedra";
            case 2: return "Papel";
            case 3: return "Tijeras";
            default: return "Desconocido";
        }
    }
}