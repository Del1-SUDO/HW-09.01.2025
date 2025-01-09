using System;
class Program{
    static void Main(){
        System.Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());
        System.Console.Write("y = ");
        int y = int.Parse(Console.ReadLine());

        Swap(ref x, ref y);
        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y}");
    }

    static void Swap(ref int a, ref int b){
        int temp = a;
        a = b;
        b = temp;
    }

}