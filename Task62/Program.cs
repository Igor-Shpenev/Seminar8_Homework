// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4;
int[,] MyMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= MyMatrix.GetLength(0) * MyMatrix.GetLength(1))
{
  MyMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < MyMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= MyMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > MyMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(MyMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
