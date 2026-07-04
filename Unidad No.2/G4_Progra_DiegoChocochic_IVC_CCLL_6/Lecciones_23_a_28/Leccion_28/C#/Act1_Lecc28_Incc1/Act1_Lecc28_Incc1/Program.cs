internal class Program
{
    private static void Main(string[] args)
    {
        int strikers = 0;
        int dinero = 0;
        int total = 0;
        do
        {
            Console.WriteLine("Tienes "+strikers+" strike(s)");
            Console.WriteLine("Ingresa la cantidad de dinero ganada");
            dinero=int.Parse(Console.ReadLine());
            if (dinero==0)
            {
                strikers++;
            }
            else
            {
                total += dinero;
            }
        }
        while (strikers<3);
        Console.WriteLine("Game Over");
    }
}