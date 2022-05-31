//Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

void PrintArray(int[,] arrayforprint)   ///метод печати массива
{
    for (int i = 0; i < arrayforprint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayforprint.GetLength(1); j++)
        {
            Console.Write($"{arrayforprint[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ReplaceRowColumn(int[,] array)  ///метод замены
{
    int[,] arr_new = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr_new[i, j] = array[j, i];
        }
    }
    return arr_new;
}

Console.Write("Введите количество строк = ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов = ");
int m = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[n, m];
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(1, 10);

if (n!=m) Console.WriteLine("Матрица не квадратная");
else
{
    int[,] arrR = ReplaceRowColumn(array);
    PrintArray(arrR);
}
PrintArray(array);

