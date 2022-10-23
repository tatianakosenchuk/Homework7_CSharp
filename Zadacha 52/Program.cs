/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}; ");
    }
}

void PrintTable(int[,] table)
{
    for (int rows = 0; rows < table.GetLength(0); rows++)
    {
        for (int columns = 0; columns < table.GetLength(1); columns++)
        {
            Console.Write($"{table[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetRandomTable(int rows, int columns)
{
    int[,] table = new int[rows, columns];
    Random rnd = new Random();
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
                table[i, j] = rnd.Next(0, 10);
        }
    }
    return table;
}

double[] AverageForColumns(int[,] table)
{
    double sum = 0;
    double[] avg = new double[(table.GetLength(1))];
    for (int j = 0; j < table.GetLength(1); j++)
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            sum += table[i, j];
            avg[j] = Math.Round(sum / table.GetLength(0), 1);
        }
        sum = 0;
    }
    return avg;
}

int[,] matrix = GetRandomTable(3, 4);
PrintTable(matrix);
double[] average = AverageForColumns(matrix);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(average);
Console.WriteLine();