internal class Program
{
    private static void Main(string[] args)
    {
        //Inicio
        Console.WriteLine("Escriba la Contraseña: ");
        string CONTRASENA = Console.ReadLine();
        //Proceso, Salida y Evaluar
        if ( CONTRASENA == "Password123")
        {
            Console.WriteLine("Bienvenido");
        }
        else
        {
            Console.WriteLine("Contraseña Incorrecta");
        }
    }
}