// See https://aka.ms/new-console-template for more information
int [,] CreatRandom2Array (int rous, int columns)
{
    int [,] newArray = new int [rous, columns];
    for (int i=0; i < rous; i++)
        for (int j=0; j < columns; j++)
             newArray [i,j] = new Random().Next(0, 100);
    
    return newArray;
}


void Show2Array (int [,] array)
{
    for (int i=0; i < array.GetLength(0); i++) 
    {
        for (int j=0; j < array.GetLength(1); j++)    
            Console.Write(array [i,j] + " ");
        Console.WriteLine();
    }
}

Console.Write("Input number of rous: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input rous index: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns index: ");
int j = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] myArray = CreatRandom2Array (m, n);
Show2Array(myArray);
Console.WriteLine();
if(i > m || j > n) 
{
    Console.Write(i);
    Console.Write(j +" ");
    Console.WriteLine ("Такого числа в массиве нет.");
}
else
    Console.WriteLine ("Значение элемента с индексами [i,j]" + " "+ myArray [i,j]); 

