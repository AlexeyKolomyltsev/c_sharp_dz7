//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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

void OrderElements(int[,] array)  ///метод упорядочивания
{
    
    for(int i = 0; i < array.GetLength(0); i++)  // ходим по строкам
    {
        
        for(int j = 0; j < array.GetLength(1) - 1; j++) //перебирам элементы строки
        {   
            int maxposition = j;
            for (int k = j + 1; k < array.GetLength(1); k++) ///сравниваем текущий элемент с остальными
            {
                if (array[i,k] > array[i, maxposition]) maxposition = k;
            }
            int tmp = array[i,j];
            array[i,j] = array[i,maxposition];
            array[i,maxposition] = tmp;
        }
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
OrderElements(array);
PrintArray(array);
