// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов. Например: 1 строка


int[,] MatrixArray(int a, int b)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] SumRowElements(int[,] array)                                                    // Возвращаем из двумерного массива одномерный,
{                                                                                     // элементами которого являются суммы строк двумерного массива
    int[] Rowsarr = new int[array.GetLength(0)];                                      

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Rowsarr[i] += array[i, j];
        }
        Console.WriteLine($"Sum of line elements {i + 1} = {Rowsarr[i]} ");
    }
    Console.WriteLine();
    return Rowsarr;
}

void SearchMinRow(int[] array)                                                         // Выявляем минимальное значение элемента (т.е строки двумерного массива)
{
    int iMin = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] < array[iMin]) iMin = i;
    }
    Console.WriteLine($"The row with the smallest sum of elements is {iMin + 1} ");

}

int[,] Arr = MatrixArray(6, 3);
PrintArr(Arr);
int[] Rowsarr = SumRowElements(Arr);
SearchMinRow(Rowsarr);
