// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
void FillMatrixSpirally(int[,] table)
{
    int n = table.GetLength(0);
    int number = 1;
    for(int k = 0; k < (n + 1)/2; k++)
    {
        for(int j = k; j < n - k; j++)
        {
            table[k, j] = number;
            number += 1;
        }
        for(int i = k + 1; i < n - k; i++)
        {
            table[i, n - 1 - k] = number;
            number += 1;
         }
        for(int j = n - k - 2; j >= k; j--)
        {
            table[n - k - 1, j] = number;
            number += 1;
        }
        for(int i = n - k - 2; i > k; i--)
        {
            table[i, k] = number;
            number += 1;
        }
        
    }
}
void PrintMatrix(int[,] table)
{
    for(int i=0; i < table.GetLength(0); i++)
    {
        for(int j=0; j < table.GetLength(1); j++)
        {
            Console.Write("{0}\t" + table[i, j]);
        }
        Console.WriteLine();
    }
}
try
{
    Console.WriteLine("Введите размерность квадратной матрицы");
    int N = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[N, N];
    FillMatrixSpirally(matrix);
    PrintMatrix(matrix);
}
catch
{
    Console.WriteLine("Вводите числа");
}
