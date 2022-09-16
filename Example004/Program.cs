// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
void FillMatrix3DRandom(int[,,] matrix)
{
    int[] arr = new int[matrix.GetLength(0) * 
                            matrix.GetLength(1) *
                                matrix.GetLength(2)];
    for (int i = 0; i < arr.Length; i++)
    {
        var num = new Random().Next(10, 100);
 
        if (arr.Contains(num))
        {
            i--;
        }
        else
        {
                    arr[i] = num;
        }
    }
    int number = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = arr[number];
                number++;
            }
        }
    }
}
void PrintMatrix3D(int[,,] matrix)
{
     for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k] + "\t");
            }
            Console.WriteLine();
        }
    }
}
void PrintMatrix3DWithIndex(int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}  ({i}, {j}, {k}){"\t"}");
            }
            Console.WriteLine();
        }
    }
}
try
{
    Console.WriteLine("Введите размерность матрицы");
    int n = Convert.ToInt32(Console.ReadLine());
    int m = Convert.ToInt32(Console.ReadLine());
    int l = Convert.ToInt32(Console.ReadLine());
    int[,,] matrix = new int[n, m, l];
    FillMatrix3DRandom(matrix);
    PrintMatrix3D(matrix);
    Console.WriteLine();
    PrintMatrix3DWithIndex(matrix);
 }
catch
{
    Console.WriteLine("Вводите только числа");
}
