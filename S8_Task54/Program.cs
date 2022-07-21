// See https://aka.ms/new-console-template for more information

int [,] CreatRandom2Array (int rous, int columns, int minValue, int maxValue)
{
    int [,] newArray = new int [rous, columns];
    for (int i=0; i < rous; i++)
        for (int j=0; j < columns; j++)
             newArray [i,j] = new Random().Next(minValue, maxValue +1);
    
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

int [,] Sort2Array (int [,] array)
{
for (int i = 0; i < array.GetLength (0); i++)
    {
    for (int j = 0; j < array.GetLength (1); j++)
        {
            for (int x=0; x < array.GetLength (1) - 1; x++)
            {
                if (array[i,j] > array[i,x])
                { 
                    int temp = 0;
                    temp = array[i,j];
                    array[i,j] = array[i,x];
                    array[i,x] = temp;
                }
            }

        }
    }
return array;
}

Console.Write("Input number of rous: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreatRandom2Array (m, n, min, max);
Show2Array(myArray);
Console.WriteLine();
Show2Array(Sort2Array(myArray));

