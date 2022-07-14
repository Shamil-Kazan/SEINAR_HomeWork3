// See https://aka.ms/new-console-template for more information

int [] CreatArray (int M)
{
    int [] newArray = new int [M];

    Console.WriteLine("Creating array here");
    for (int i=0; i < M; i++)
    {
        Console.Write($"Input {i+1} element: ");
        newArray [i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

void ShowArray (int [] array)
{
    for (int i=0; i < array.Length; i++)    
        Console.Write(array [i] + " ");

    Console.WriteLine();
}

Console.Write("Input size of array M: ");
int M = Convert.ToInt32(Console.ReadLine());
int [] array = CreatArray (M);

ShowArray (array);

int count = 0; 
M = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) count += 1;
    }

Console.WriteLine();
Console.WriteLine(count);
