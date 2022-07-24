// See https://aka.ms/new-console-template for more information

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 
int ShowNums(int m, int n)
{
    if(n == m) 
        return n;
        return m + ShowNums(m+1, n);
}
Console.WriteLine(ShowNums(2, 5));

