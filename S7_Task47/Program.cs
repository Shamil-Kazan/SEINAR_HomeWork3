// See https://aka.ms/new-console-template for more information

double [,] CreatRandom2Array (int rous, int columns)
{
    double [,] newArray = new double [rous, columns];
    for (int i=0; i < rous; i++)
        for (int j=0; j < columns; j++)
             newArray [i,j] = (new Random().NextDouble()*10);
    
    return newArray;
}

void Show2Array (double [,] array)
{
    for (int i=0; i < array.GetLength(0); i++) 
    {
        for (int j=0; j < array.GetLength(1); j++)
           {
            double ArrayNumber = Math.Round(array[i, j], 2);
            Console.Write(ArrayNumber + " ");
           }
           
        Console.WriteLine();
    }
}


Console.Write("Input number of rous: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] myArray = CreatRandom2Array (m, n);
Show2Array(myArray);
