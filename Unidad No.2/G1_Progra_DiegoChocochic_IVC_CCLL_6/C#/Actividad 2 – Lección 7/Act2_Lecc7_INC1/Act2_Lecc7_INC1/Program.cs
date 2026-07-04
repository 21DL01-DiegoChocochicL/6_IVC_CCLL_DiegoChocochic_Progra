internal class Program
{
    private static void Main(string[] args)
    {
        //Inicio
        Console.WriteLine("Digite los siguientes Numeros (1,2,3,4) para continuar:");
        int n =int.Parse(Console.ReadLine());

        //Proceso, Salida y Evaluar
        if (n == 1)
        {
            Console.WriteLine("Gracias Por escojer la opcion de Comunicarse a la cental");
        }else if (n == 2) {
            Console.WriteLine("Gracias por escojer la opcion de Comunicarse con el Administrador");
            }
        else if (n == 3) {
            Console.WriteLine("Gracias por escojer la opcion de Comunicarse con Gerente de Sotfware");
            }
        else if(n == 4) {
            Console.WriteLine("Gracias por escojer la opcion de Comunicarse con el Encargado de ventas");
        }
        else {
            Console.WriteLine("No esta este numero como opcion");
        }
    }
}