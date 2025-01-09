using System;
class Program{
    static void Main(){
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("y = ");
        int y = int.Parse(Console.ReadLine());

        int result = Pow(x, y);
        Console.WriteLine($"{result}");
    }

    static int Pow(int x, int y){
        return (int)Math.Pow(x, y);
    }

}