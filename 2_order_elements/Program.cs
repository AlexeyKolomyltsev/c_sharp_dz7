//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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

int MaxIndex(int[,] array, int numberrow, int startnumbercolumn)
{
    int maxposition = startnumbercolumn;
    for (int k = startnumbercolumn + 1; k < array.GetLength(1); k++) 
    {
        if (array[numberrow, k] > array[numberrow, maxposition]) maxposition = k; ///находим индек максимального элемента
    }
    return maxposition;
}

void OrderElements(int[,] array)   ///метод упорядочивания
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++) //перебирам элементы строки
        {
            int maxi = MaxIndex(array, i, j);                   ///
            int tmp = array[i, j];                              ///меняем местами текущий и максимальный элементы строки
            array[i, j] = array[i, maxi];                       ///
            array[i, maxi] = tmp;                               ///
        }
    }
}


Console.Write("Введите количество строк = ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов = ");
int m = int.Parse(Console.ReadLine() ?? "0");
int[,] array = new int[n, m];
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(1, 10);

PrintArray(array);
OrderElements(array);
PrintArray(array);
