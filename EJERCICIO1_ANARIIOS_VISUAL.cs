internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matrizColumnas = new int[4, 4];

        for (int fila = 0; fila < 4; fila++)
        {
            for (int columna = 0; columna < 4; columna++)
            {
                matrizColumnas[fila, columna] = columna + 1;
            }
        }

        Console.WriteLine("Matriz de Columnas");

        for (int fila = 0; fila < 4; fila++)
        {
            for (int columna = 0; columna < 4; columna++)
            {
                Console.Write(matrizColumnas[fila, columna] + " ");
            }

            Console.WriteLine();
        }
    }
}