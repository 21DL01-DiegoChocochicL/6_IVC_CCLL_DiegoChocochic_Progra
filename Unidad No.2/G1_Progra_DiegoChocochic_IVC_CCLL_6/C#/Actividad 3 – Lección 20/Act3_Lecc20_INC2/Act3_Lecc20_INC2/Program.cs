internal class Program
{
    private static void Main(string[] args)
    {
        //Inicio
        Console.WriteLine("Digame la clase que quiere ver si ha aprovado: ");
        string C = Console.ReadLine();
        Console.WriteLine("Digame su nota: ");
        float n = float.Parse(Console.ReadLine());
        //Proceso,Salida y Evaluar
        if (n >= 70 && n <=100)
        {
            Console.WriteLine(C+ ", esta clase esta aprovada.");
        }
        else
        {
            Console.WriteLine(C+ ", Esta clase esta reprovada");
        }

    }
}