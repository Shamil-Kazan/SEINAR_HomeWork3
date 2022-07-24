// See https://aka.ms/new-console-template for more information

// Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.
int count (int N)
{
    if (N/10!=0)
        return 1+count(N/10);
    else
        return 1;
}
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(count(N));

