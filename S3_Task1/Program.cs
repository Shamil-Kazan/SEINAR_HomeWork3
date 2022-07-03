// See https://aka.ms/new-console-template for more information
void Palindrom(int number)
{ 
    if(number <10000 || number >99999)
    {
    Console.WriteLine("Error");
    }
    else
    {
    int index1 = number/10000;
    int index2 = (number/1000)%10;
    int index4 = (number/10)%10;
    int index5 = number%10;
        if(index1==index5 && index2==index4)
        {
            Console.WriteLine("Это палиндром");
        }

        else
        {
        Console.WriteLine("Это не палиндром");
        }
    }
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num);

