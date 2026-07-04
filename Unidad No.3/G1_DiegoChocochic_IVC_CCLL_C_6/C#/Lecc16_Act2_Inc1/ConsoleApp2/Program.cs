internal class Program
{
    private static void Main(string[] args)
    {
        //Lecc30_Act2_Inc1

        Console.WriteLine("Datoas academiscos\n Nombre: Diego Chocochic" + "\n Grado: Iv Bach. CCLL Compu." + "\nClave:6");

        int[] edadPerson = new int[4];
        int CantidadPersonMayor = 0;
        int CantidadPersonMenor = 0;
        int CantidadPerson = 0;

        for (int i = 0; i < edadPerson.Length; i++)
        {
            Console.WriteLine($"Ingrese la edad de la persona {i+1}");
            edadPerson[i] = Convert.ToInt32(Console.ReadLine());
            if (edadPerson[i]>=18)
            {
                CantidadPersonMayor++;
            }
            else
            {
                CantidadPersonMenor++;
            }
            CantidadPerson++;
        }
        Console.WriteLine();
        Console.WriteLine("Cantidad de personas mayores de edad: "+CantidadPersonMayor);
        Console.WriteLine("Cantidad de personas menores de edad: " + CantidadPersonMenor);
        Console.WriteLine("Cantidad de personas ingresadas: " + CantidadPerson);
    }
}