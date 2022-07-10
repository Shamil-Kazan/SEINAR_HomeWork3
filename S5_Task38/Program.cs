// See https://aka.ms/new-console-template for more information
double [] CreateRandomArray (int size=10, double minValue =1, double maxValue = 100)
{
    double [] newArray = new double [10];
    for (int i=0; i < 10; i++)
        newArray [i] = new Random().Next(1, 100);
    
    return newArray;
}

void ShowArray (double [] array)
{
    for (int i=0; i < array.Length; i++)    
        Console.Write(array [i] + " ");

    Console.WriteLine();
}

void DiffMinMax (double [] array)
{
    int index = 0;
    int length = array.Length;
    double min = array [0];
    double max = array [0];
    while (index < length)
        {
            if(array[index]<min) min = array[index];
            if(array[index]>max) max = array[index];
            index ++;
        }
    double differens = max - min;
    
    Console.WriteLine($"Минимальное значение массива: {min}");
    Console.WriteLine($"Максимальное значение массива: {max}");
    Console.WriteLine($"Разность между max и min: {max - min}");
}

double [] array = CreateRandomArray (10, 1, 100); //почему при типе double массив заполняется только целыми числами?

ShowArray (array);
DiffMinMax (array);

