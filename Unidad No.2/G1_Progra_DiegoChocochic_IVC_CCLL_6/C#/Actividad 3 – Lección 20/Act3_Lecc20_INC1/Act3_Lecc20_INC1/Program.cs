internal class Program
{
    private static void Main(string[] args)
    {
        //Inicio
        Console.WriteLine("Escribe un numero (1-7): ");
        int num = int.Parse(Console.ReadLine());
        //Proceso,Salida y Evaluar
        if (num == 1 || num==2||num==3||num==4||num==5)
        {
            Console.WriteLine("Es Entre Semana");
        }
        else if (num==6 || num==7)
        {
            Console.WriteLine("Es Fin de Semana");
        }
        else
        {
            Console.WriteLine("Numero no reconocible");
        }
    }
}