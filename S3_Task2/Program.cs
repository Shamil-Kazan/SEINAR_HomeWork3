// See https://aka.ms/new-console-template for more information
void CubeNum(int num)
{
    int current = 1;

    while(current <= num)
    {
        int cube = current*current*current;
        Console.Write(cube + ", ");
        current++;
    }

}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
CubeNum (num);
