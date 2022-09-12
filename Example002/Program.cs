// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
int NumberRowMinAvg(int[,] table)
{
    double[] avgRows = new double[table.GetLength(0)];
    for(int i=0; i < table.GetLength(0); i++)
    {
        var sum = 0;
        for(int j=0; j < table.GetLength(1); j++)
        {
            sum += table[i, j];
        }
        avgRows[i] = Math.Round(Convert.ToDouble(sum)/table.GetLength(1), 1);
    }
    int posMin = 0;
    for(int i=0; i < avgRows.Length; i++)
    {
        if(avgRows[i] < avgRows[posMin]) posMin = i;
    }
    return (posMin + 1);
}
try
{
     Console.WriteLine("Введите размерность матрицы");
    int n = Convert.ToInt32(Console.ReadLine());
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[n, m];
    FillMatrix(matrix);
    PrintMatrix(matrix);
    Console.WriteLine();
    Console.WriteLine($"{NumberRowMinAvg(matrix)} строка");
 }
catch
{
    Console.WriteLine("Вводите только числа");
}
