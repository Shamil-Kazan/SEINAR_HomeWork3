// See https://aka.ms/new-console-template for more information
int SumDigit(int num)
 {
     int summa = 0;
     if (num < 0)
     num = Math.Abs(num); //модуль числа
     while (num > 0)
     {   
        int num1;
        num1 = num % 10;
        num = (num /10);
        summa = summa + num1;
     }
     return summa;
 }
 Console.WriteLine("Введите число");
 int n = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Сумма цифр числа: "+ SumDigit(n));
