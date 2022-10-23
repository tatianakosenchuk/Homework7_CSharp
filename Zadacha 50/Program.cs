/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
 или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int Getnumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

void PrintTable(int[,] table)
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

void SearchTableByIndex(int[,] table, int rowNumber, int columnNumber)
{
    if (rowNumber >= 0 && rowNumber <table.GetLength(0) && columnNumber >= 0 && columnNumber < table.GetLength(1)) 
    Console.WriteLine($"в {rowNumber} строке {columnNumber} столбца находится число {table[rowNumber,columnNumber]}");
    else Console.WriteLine($"{rowNumber} {columnNumber} -> такого числа в массиве нет");
}

int[,] table = GetRandomTable(3,4);
Console.WriteLine();
PrintTable(table);
int row = Getnumber("Введите номер строки");
int column = Getnumber("Введите номер столбца");
SearchTableByIndex(table, row, column);

