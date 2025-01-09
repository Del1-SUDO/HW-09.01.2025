using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Minimum number: {MinDigit(n)}");
        Console.WriteLine($"Maximum number: {MaxDigit(n)}");
        Console.WriteLine($"The sum is {MinDigit(n)} + {MaxDigit(n)} = {MinDigit(n)+MaxDigit(n)}");
    }

    static int MinDigit(int n){
        int min = 9;
        while(n>0){
            int digit = n%10;
            if (digit<min){
                min=digit;
            }
            n/=10;
        }
        return min;
    }

    static int MaxDigit(int n){
        int max = 0;
        while(n>0){
            int digit = n%10;
            if (digit>max){
                max=digit;
            }
            n/=10;
        }
        return max;
    }
}