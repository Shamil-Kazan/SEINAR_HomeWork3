// See https://aka.ms/new-console-template for more information
int [] CreateRandomArray (int size, int minValue=100, int maxValue=999)
{
    int [] newArray = new int [size];
    for (int i=0; i < size; i++)
        newArray [i] = new Random().Next(minValue, maxValue +1);
    
    return newArray;
}

void ShowArray (int [] array)
{
    for (int i=0; i < array.Length; i++)    
        Console.Write(array [i] + ", ");

    Console.WriteLine();
}

int QuantityEven (int [] array)
{
    int sum = 0;

    for (int i=0; i < array.Length; i++) 
        if(array [i]%2==0) sum ++;
        return sum;       
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandomArray (size, 100, 999);

ShowArray (array);
int even = QuantityEven (array);
Console.WriteLine (even);