internal class Program
{
    private static void Main(string[] args)
    {
        //desarrolla una agenda telefonica deonde guardes el nombre y el telefono de 10 personas. Al ingresar el numero 
        //de posicion de la lista, el programa debe mostrar los datos almacenados en esa posicon
        Console.WriteLine("Nombre:Diego Alejandro Chocochic L.\n" + "Grado:IV Bach. CC.LL\n" + "Seccion:C\n" + "Calve:6\n"
        + "Agenda\n" + "");

        string[] nombres = new string[10];
        string[] telefonos = new string[10];

        Console.WriteLine("--- Registro de la Agenda Telefónica ---");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"\nRegistro #{i + 1}:");
            Console.Write("Nombre: ");
            nombres[i] = Console.ReadLine();
            Console.Write("Teléfono: ");
            telefonos[i] = Console.ReadLine();
        }

        Console.WriteLine("\n--- Búsqueda en la Agenda ---");
        bool continuar = true;

        while (continuar)
        {
            Console.Write("\nIngrese el número de posición que desea consultar: ");
            int posicion = Convert.ToInt32(Console.ReadLine());

            if (posicion == 0)
            {
                continuar = false;
            }
            else if (posicion >= 1 && posicion <= 10)
            {
                int indice = posicion - 1;
                Console.WriteLine($"\nDatos en la posición {posicion}:");
                Console.WriteLine($"Nombre: {nombres[indice]}");
                Console.WriteLine($"Teléfono: {telefonos[indice]}");
            }
            else
            {
                Console.WriteLine("Posición no válida. Debe ingresar un número entre 1 y 10.");
            }
        }

        Console.WriteLine("\nPrograma finalizado. ¡Hasta pronto!");
    }
}