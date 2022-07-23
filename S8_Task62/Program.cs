// See https://aka.ms/new-console-template for more information

int [,] CreatRandom2Array (int rous, int columns)
{
    int [,] array = new int [rous, columns];
        
    int Ibegin = 0, Ifinish = 0, Jbegin = 0, Jfinish = 0; //начало и концы строк и столбцов
    
    int element = 1;
    int i = 0;
    int j = 0;

    while (element <= rous * columns)
    {
        array [i,j] = element;
        if (i == Ibegin && j < columns - Jfinish - 1)
            ++j;
        else if (j == columns - Jfinish - 1 && i < rous - Ifinish - 1)
            ++i;
        else if (i == rous - Ifinish - 1 && j > Jbegin)
            --j;
        else
            --i;

        if ((i == Ibegin + 1) && (j == Jbegin) && (Jbegin != columns - Jfinish - 1))
        {
            ++Ibegin;
            ++Ifinish;
            ++Jbegin;
            ++Jfinish;
        }
        ++element;
    }    
    return array;
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

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = m; 
Console.WriteLine();
int [,] myArray = CreatRandom2Array (m, n);
Show2Array(myArray);
Console.WriteLine();
