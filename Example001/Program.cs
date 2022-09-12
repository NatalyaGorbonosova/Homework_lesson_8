// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void FillMatrix(int[,] table)
{
    for(int i=0; i < table.GetLength(0); i++)
    {
        for(int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(0, 20);
        }
    }
}
void PrintMatrix(int[,] table)
{
    for(int i=0; i < table.GetLength(0); i++)
    {
        for(int j=0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void SortRowsMatrix(int[,] table)
{
    for(int i=0; i<table.GetLength(0); i++)
    {
        for(int k=0; k<table.GetLength(1); k++)
        {
            int min = table[i, 0];
            int minPos = 0;
            for(int j = 0; j < table.GetLength(1) - k; j++)
             {
                if(table[i, j] < min)
                {
                    min = table[i, j];
                    minPos = j;
                }
             }
            int temp = table[i, minPos];
            table[i, minPos] = table[i, table.GetLength(1) - 1 - k];
            table[i, table.GetLength(1) - 1 - k] = temp;
        }
        
    }
}
try
{
     Console.WriteLine("Введите размерность матрицы");
    int n = Convert.ToInt32(Console.ReadLine());
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[n, m];
    FillMatrix(matrix);
    PrintMatrix(matrix);
    SortRowsMatrix(matrix);
    Console.WriteLine();
    PrintMatrix(matrix);
 }
catch
{
    Console.WriteLine("Вводите только числа");
}