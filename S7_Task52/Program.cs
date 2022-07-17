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

void ArithmeticMean(int[,] array)
{
    int count = array.GetLength(0);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summa = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            {
                summa += array[i, j];
            }
        double ArithMean = Math.Round((summa/count), 2);
        Console.Write(ArithMean + ";  ");
    }
}

Console.Write("Input number of rous: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreatRandom2Array (m, n);
Show2Array(myArray);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца:  ");
ArithmeticMean(myArray);

