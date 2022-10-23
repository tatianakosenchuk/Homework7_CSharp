/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

void PrintTable(double[,] table)
{
    for (int rows = 0; rows < table.GetLength(0); rows++)
    {
        for (int columns = 0; columns < table.GetLength(1); columns++)
        {
            Console.Write($"{table[rows, columns]}  ");
        }
        Console.WriteLine();
    }
}

double[,] GetRandomTable(int rows, int columns)
{
    double[,] table = new double[rows, columns];
    Random rnd = new Random();
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
                table[i, j] = Math.Round((rnd.Next(-10, 10) + rnd.NextDouble()),1);
        }
    }
    return table;
}

double[,] randomTable = GetRandomTable(3, 4);
PrintTable(randomTable);
