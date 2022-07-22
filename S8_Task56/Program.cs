// See https://aka.ms/new-console-template for more information

int [,] CreatRandom2Array (int rous, int columns, int minValue, int maxValue)
{
    int [,] newArray = new int [rous, columns];
    for (int i=0; i < rous; i++)
        for (int j=0; j < columns; j++)
             newArray [i,j] = new Random().Next(minValue, maxValue +1);
    
    return newArray;
}

void Show2Array (int [,] newArray)
{
    for (int i=0; i < newArray.GetLength(0); i++) 
    {
        for (int j=0; j < newArray.GetLength(1); j++)    
            Console.Write(newArray [i,j] + " ");
        Console.WriteLine();
    }
}

void RowsSumma(int[,] array)
{
    int [] new1Array = new int[array.GetLength(0)]; //Создадим одномерный массив для записи суммы строк
    int ind = 0;
    
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                 sum = sum + array[i, j];                    
            }
        new1Array[ind] = sum;
        ind++;
        }
    int min = new1Array[0];
    for (int ind1 = 0; ind1 < new1Array.Length; ind1++)
    {
        if (new1Array[ind1] < min)
        {
            min = new1Array[ind1];
        }
    }
    Console.WriteLine($"Минимальная сумма:  {min}");
    int indexMin = Array.IndexOf(new1Array, min);
    Console.WriteLine($"Номер строки с минимальной суммой: {indexMin}");
}

Console.Write("Input number of rous: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] myArray = CreatRandom2Array (m, n, min, max);
Show2Array(myArray);
Console.WriteLine();
RowsSumma(myArray);