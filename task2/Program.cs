using System;
class Program
{
    static void Main(){
        Console.WriteLine("Enter your numbers in a column: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Add: {Add(a,b)}");
        Console.WriteLine($"Subtract: {Subtract(a,b)}");
        Console.WriteLine($"Multiply: {Multiply(a,b)}");
        Console.WriteLine($"Division: {Division(a,b)}");
    }

    static int Add(int a, int b){
        return a+b;
    }

    static int Subtract(int a, int b){
        return a-b;
    }

    static int Multiply(int a, int b){
        return a*b;
    }

    static int Division(int a, int b){
        return a/b;
    }
}