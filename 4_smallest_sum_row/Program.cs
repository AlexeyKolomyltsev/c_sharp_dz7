// В прямоугольной матрице найти строку с наименьшей суммой элементов.
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

void SmallestRow(int[,] array)  ///метод проверки строки с наименьшей суммой
{

    int[] sumA = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumA[i] += array[i, j];
        }
    }
    int minIndex = 0;
    for (int i=0; i<sumA.Length; i++)
        if (sumA[i] < sumA[minIndex]) minIndex = i;
    Console.WriteLine($"Минимальная сумма строки равна {sumA[minIndex]}, номер строки {minIndex} (отсчет с 0)");
}

Console.Write("Введите количество строк = ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов = ");
int m = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[n, m];
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(1, 10);


PrintArray(array);
SmallestRow(array);