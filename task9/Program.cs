using System;

class Program
{
    static void Main() {
        Console.Write("Enter first number: ");
        int val1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int val2 = int.Parse(Console.ReadLine());

        int result = Min(val1, val2);
        Console.WriteLine(result);
    }

    static int Min(int val1, int val2) {
        if (val1 < val2) {
            return val1;
        }
        else {
            return val2;
        }
    }
}
