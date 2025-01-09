using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Even:{Even(n)}");
        Console.WriteLine($"Odd:{Odd(n)}");
        Console.WriteLine($"Digit:{Count(n)}");
        Console.WriteLine($"Sum:{Sum(n)}");
    }

    static int Even(int n)
    {
        int count = 0;
        foreach (char digit in n.ToString())
        {
            if ((digit - '0') % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

    static int Odd(int n)
    {
        int count = 0;
        foreach (char digit in n.ToString())
        {
            if ((digit - '0') % 2 != 0)
            {
                count++;
            }
        }
        return count;
    }

    static int Count(int n)
    {
        return n.ToString().Length;
    }

    static int Sum(int n)
    {
        int sum = 0;
        foreach (char digit in n.ToString())
        {
            sum += digit - '0';
        }
        return sum;
    }
}