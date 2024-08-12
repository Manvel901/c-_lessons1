
using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        int i = 5;

        while (i <= 70)
        {
            sum += i;
            i++;
        }
        
        Console.WriteLine("Сумма чисел от 5 до 70: " + sum);
    }
}
