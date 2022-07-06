// See https://aka.ms/new-console-template for more information
void FillArray (int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index<length)
        {collection[index] = new Random().Next(1, 1000);
        index ++;
        }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while(position<count)
    {
        Console.Write(col[position] + ", ");
        position ++;
    }
}

Console.WriteLine("Введите длину массива");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int [num];
FillArray(array);
Console.Write("[");
PrintArray(array);
Console.Write("]");

