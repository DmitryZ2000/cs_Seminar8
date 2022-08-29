// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] CreateMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] SwapRow(int[,] array)
{
    int rowCount = array.GetLength(0);
    for (int i = 0; i < array.GetLength(1); i++)
    {
        //array[0,i] <-> array[rowCount-1,i]
        int temp = array[0,i];
        array[0,i] = array[rowCount-1,i];
        array[rowCount-1,i] = temp;
    }
    return array;
}

int[,] array = CreateMatrix(3,3);
PrintMatrix(array);
Console.WriteLine();
SwapRow(array);
PrintMatrix(array);