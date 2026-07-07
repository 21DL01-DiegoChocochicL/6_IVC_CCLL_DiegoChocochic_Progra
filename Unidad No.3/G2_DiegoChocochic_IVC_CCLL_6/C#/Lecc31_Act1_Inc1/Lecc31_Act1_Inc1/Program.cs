internal class Program
{
    private static void Main(string[] args)
    {
       
        //Diego Alejandro Chocochic L. IV Bach. CC.LL. Compu. "C" clave:6
        Console.WriteLine($"n/ Nombre: Diego Chocochic"+"n/Grado: IV Bach. CC.LL. Compu. C"+"n/Clave:6"+"n/Guardar Numeroes en fila");
        int filas = 3;
        int columnas = 5;
        int i = 0; 
        int j = 0;
        int [ , ]matriz1 = new int[3, 5];

        for (i=0; i < filas; i++)
        {
            for (j=0 ; j < columnas; j++)
            {
                Console.WriteLine("Ingrese el numero que quieres guardar en la fila: " + i + ", Columna: " + j + " =");
                matriz1[i,j] = int.Parse(Console.ReadLine());
            }
        }
        for (i = 0; i < filas; i++)
        {
            for (j = 0; j < columnas; j++)
            {
                Console.WriteLine("Fila: "+i+". Columna: "+j+" =" + matriz1[i,j] );
            }
        }
    }
}