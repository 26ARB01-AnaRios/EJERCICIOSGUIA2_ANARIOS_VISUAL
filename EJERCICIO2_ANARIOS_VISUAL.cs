internal class Program
{
    private static void Main(string[] args)
    {
        int[,] tabla = new int[4, 3];

        for (int fila = 0; fila < 4; fila++)
        {
            int suma = 0;

            for (int columna = 0; columna < 3; columna++)
            {
                Console.Write("Ingrese un número: ");
                tabla[fila, columna] = Convert.ToInt32(Console.ReadLine());

                suma += tabla[fila, columna];
            }

            Console.WriteLine("La suma de la fila " + (fila + 1) + " es: " + suma);
        }
    }
}