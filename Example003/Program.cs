// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void FillMatrix(int[,] table)
{
    for(int i=0; i < table.GetLength(0); i++)
    {
        for(int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(0, 10);
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
int[,] MultiplicationMatrix(int[,] tableFirst, int[,] tableSecond)
{
    int[,] mult = new int[tableFirst.GetLength(0), tableSecond.GetLength(1)];
    int[] arrFirstRows = new int[tableFirst.GetLength(1)];
    int[] arrSecondColums = new int[tableSecond.GetLength(0)];
    for(int i = 0; i < tableFirst.GetLength(0); i++)
    {
        for(int j = 0; j < tableFirst.GetLength(1); j++)
        {
            arrFirstRows[j] = tableFirst[i, j];
        }
        for(int j1 = 0; j1 < tableSecond.GetLength(1); j1++)
        {
            int sum = 0;
            for(int i1 = 0; i1 < tableSecond.GetLength(0); i1++)
            {
                arrSecondColums[i1] = tableSecond[i1, j1];
                sum += arrFirstRows[i1] * arrSecondColums[i1];
            }
            mult[i, j1] = sum;
        }
    }
    return mult;
}
try
{
     Console.WriteLine("Введите размерность первой матрицы");
    int n = Convert.ToInt32(Console.ReadLine());
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] matrixFirst = new int[n, m];
    FillMatrix(matrixFirst);
    PrintMatrix(matrixFirst);
    Console.WriteLine();
     Console.WriteLine("Введите размерность второй матрицы");
    int k = Convert.ToInt32(Console.ReadLine());
    int l = Convert.ToInt32(Console.ReadLine());
    int[,] matrixSecond = new int[k, l];
    FillMatrix(matrixSecond);
    PrintMatrix(matrixSecond);
    Console.WriteLine();
    if(m == k)
    {
        Console.WriteLine("Произведение матриц равно");
        int[,] multMatrix = MultiplicationMatrix(matrixFirst, matrixSecond);
        PrintMatrix(multMatrix);
    }
    else Console.WriteLine("Эти матрицы умножить нельзя");
    
 }
catch
{
    Console.WriteLine("Вводите только числа");
}
