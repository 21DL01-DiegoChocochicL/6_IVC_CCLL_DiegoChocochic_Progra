internal class Program
{
    private static void Main(string[] args)
    {
        //Crea un programa que inventa la frase que ingrese el usuario. Por ejemplo, al recibir "Hola Mundo", 
        //el programa muestra ""
        Console.WriteLine("Nombre:Diego Alejandro Chocochic L.\n" + "Grado:IV Bach. CC.LL\n" + "Seccion:C\n" + "Calve:6\n"
        + "Conversiones\n" + "");

        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();

        string fraseInvertida = "";

        for (int i = frase.Length - 1; i >= 0; i--)
        {
            fraseInvertida += frase[i];
        }

        Console.WriteLine($"\nFrase invertida: {fraseInvertida}");
    }
}