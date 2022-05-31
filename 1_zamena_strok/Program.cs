/// Написать программу, которая обменивает элементы первой строки и последней строки
void PrintArray(int[,] arrayforprint)   ///метод печати массива
{
    for(int i = 0; i < arrayforprint.GetLength(0); i++){
        for(int j = 0; j < arrayforprint.GetLength(1); j++)
        {
            Console.Write($"{arrayforprint[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();   
}

void ReplaceRowArray(int[,] array)  ///метод замены первой и последней строки местами
{
    int tmpArray;
    for(int j = 0; j < array.GetLength(1); j++) 
    {
        tmpArray = array[0,j];
        array[0,j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = tmpArray;
    }
}

Console.Write("Введите количество строк = ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов = ");
int m = int.Parse(Console.ReadLine() ?? "0");
int[,] array = new int[n,m];
for(int i = 0; i < array.GetLength(0); i++)
    for(int j = 0; j < array.GetLength(1); j++) array[i,j] = new Random().Next(1,10);

PrintArray(array);
ReplaceRowArray(array);
PrintArray(array);

