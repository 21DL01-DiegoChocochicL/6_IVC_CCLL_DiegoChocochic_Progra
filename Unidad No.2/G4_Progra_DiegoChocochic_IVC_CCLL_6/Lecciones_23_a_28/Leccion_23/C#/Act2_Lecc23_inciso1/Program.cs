namespace Act2_Lecc9_inciso1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int monedas = 0;

            Console.WriteLine("*******************************************");
            Console.WriteLine("       ¡BIENVENIDO AL DESAFÍO NIVEL 5!      ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Para entrar al Nivel 5 necesitas 350 monedas.");

            while (monedas < 350)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Estado: Nivel 5 Bloqueado.");
                Console.Write("Ingresa cuántas monedas tienes para subir de nivel: ");
                monedas = int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("*******************************************");
            Console.WriteLine("¡Felicidades! Has alcanzado las " + monedas + " monedas.");
            Console.WriteLine("Nivel 5 Desbloqueado.");
            Console.WriteLine("*******************************************");
        }
    }
}
