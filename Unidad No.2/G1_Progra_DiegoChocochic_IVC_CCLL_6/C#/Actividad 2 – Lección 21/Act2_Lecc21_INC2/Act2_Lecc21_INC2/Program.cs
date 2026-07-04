internal class Program
{
    private static void Main(string[] args)
    {
        //Inicio
        Console.WriteLine("Bienvenido puede escojer una de estas opciones (1 Ventas, 2 Recepción, 3 Dirección y 4 Compras):" );
        int n = int.Parse( Console.ReadLine() );
        //Proceso, Salida y Evaluar
        if ( n == 1)
        {
            Console.WriteLine("Bienvenido a Ventas. No podemos atenderte ahora, pero el responsable es Carlos Méndez. Puedes escribirle a ventas@empresa.com o dejar tu mensaje tras el tono. Gracias.");
        }
        else if ( n == 2)
        {
            Console.WriteLine("Gracias por llamar a Recepción. Para una atención directa, contacta con Lucía Fernández en info@empresa.com, o deja tus datos ahora y te llamaremos pronto.");
        }
        else if (n == 3)
        {
            Console.WriteLine("Has comunicado con Dirección. Para asuntos urgentes, contacta con Ricardo Sanz al correo direccion@empresa.com. De lo contrario, deja tu mensaje después de la señal.");
        }
        else if (n == 4)
        {
            Console.WriteLine("Bienvenido a Compras. Si eres proveedor, contacta con nuestro responsable, Elena Rivas, en compras@empresa.com. También puedes dejar tu mensaje detallado ahora.");
        }
        else
        {
            Console.WriteLine("Numero no valido");
        }

    }
}