internal class Program
{
    private static void Main(string[] args)
    {
        int[,] tabla = new int[4, 4];

        for (int fila = 0; fila < 4; fila++)
        {
            for (int columna = 0; columna < 4; columna++)
            {
                Console.Write("Ingrese un número: ");
                tabla[fila, columna] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int mayor = tabla[0, 0];
        int x = 1;
        int y = 1;

        for (int fila = 0; fila < 4; fila++)
        {
            for (int columna = 0; columna < 4; columna++)
            {
                if (tabla[fila, columna] > mayor)
                {
                    mayor = tabla[fila, columna];
                    x = fila + 1;
                    y = columna + 1;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("El número mayor es: " + mayor);
        Console.WriteLine("Está en la fila: " + x);
        Console.WriteLine("Está en la columna: " + y);
    }
}