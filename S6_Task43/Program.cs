// See https://aka.ms/new-console-template for more information

void LineCrossPoint (double k1,  double b1,  double k2,  double b2)
{
    if (k1==k2 && b1==b2) // условие совпадения прямых
     Console.WriteLine("lines match");
             
    else if (k1==k2) // условие параллельности прямых из курса алгебры
     Console.WriteLine("lines are parallel");

    else
    {
        double x = ((b2 - b1)/(k1 - k2));
        //в точке пересечения k1*x + b1 = k2*x + b2 => x = (b2 - b1) / (k1 - k2)
        double y = ((k1 * x + b1));
        Console.WriteLine();
        Console.Write("({0: 0.00}",x);
        Console.WriteLine("{0: 0.00})",y); // Павел, как записать в одну строку 17 и 18????
    }
}
Console.WriteLine("Enter k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
LineCrossPoint(k1, b1, k2, b2);

