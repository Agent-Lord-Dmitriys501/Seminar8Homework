// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*
int[,] CreateRandom2dArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] YporadPoYbivanieStroki(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int min = 0; min < arr.GetLength(1) - 1; min++)
            {
                if (arr[i, min] < arr[i, min + 1])
                {
                    temp = arr[i, min + 1];
                    arr[i, min + 1] = arr[i, min];
                    arr[i, min] = temp;
                }
            }
        }
    }
    return arr;
}

Console.Write("Введите количество столбцов: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимум: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимум: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(rows, cols, min, max);
Show2dArray(array);
Console.WriteLine();
int[,] array2 = YporadPoYbivanieStroki(array);
Show2dArray(array2);
*/

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateRandom2dArray(int min, int max)
{
    int[,] array = new int[3, 4];
    for (int i = 0; i < 3; i++)
        for (int j = 0; j < 4; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void StrokaSNaimenSymmaElement(int[,] arr)
{
    int minsum = Int32.MaxValue;
    int indexMass = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            indexMass++;
        }
    }
    Console.WriteLine("Cтрока с наименьшей суммой элементов в прямоугольном " +
                       "двумерном массиве находится под номером: " +
                     +(indexMass) + ", с суммой элементов которой равно: " + (minsum));

}


Console.Write("Введите минимум: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимум: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(min, max);
Show2dArray(array);
Console.WriteLine();
StrokaSNaimenSymmaElement(array);

