internal class Program
{
    private static void Main(string[] args)
    {
        // Muestra un menú: 1 = Hamburguesa, 2 = Pizza, 3 = Pollo frito, 4 = Ensalada - El usuario elige una
        // opción y el programa muestra el pedido.

        // Inicio
        Console.WriteLine("\t* Menu");
        Console.WriteLine("\t**********************************************");
        Console.WriteLine("\t* El menu de hoy es:                         *");
        Console.WriteLine("\t* 1- Hamburguesa                             *");
        Console.WriteLine("\t* 2- Pizza                                   *");
        Console.WriteLine("\t* 3- Pollo Frito                             *");
        Console.WriteLine("\t* 4- Ensalada                                *");
        Console.WriteLine("\t**********************************************");

        Console.WriteLine("Que desea el dia de hoy?");
        int n1 = Convert.ToInt32(Console.ReadLine());

        // Proceso, Salida y Sentencia de Seleccion
        switch (n1) {
            case 1:
                Console.WriteLine("Entendido la comida esta en camino, una hamburgesa");
                break;
            case 2:
                Console.WriteLine("Entendido la comida esta en camino, una piza");
                break;
            case 3:
                Console.WriteLine("Entendido la comida esta en camino, un Pollo frito");
                break;
            case 4:
                Console.WriteLine("Entendido la comida esta en camino, una ensalada");
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
    }
}