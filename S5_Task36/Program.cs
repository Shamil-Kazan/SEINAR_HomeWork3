// See https://aka.ms/new-console-template for more information
int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    for (int i=0; i < size; i++)
        newArray [i] = new Random().Next(minValue, maxValue +1);
    
    return newArray;
}

void ShowArray (int [] array)
{
    for (int i=0; i < array.Length; i++)    
        Console.Write(array [i] + " ");

    Console.WriteLine();
}

int SumOddIndex (int [] array)
{
    int sum = 0;
    
    for (int i=1; i < array.Length; i+=2) 
        sum = sum + array[i];
        return sum;       
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandomArray (size, min, max);

ShowArray (array);
int summa = SumOddIndex (array);
Console.WriteLine (summa);
