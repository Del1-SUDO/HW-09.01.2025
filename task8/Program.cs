using System;
class Program{
    static void Main(){
        Console.Write("Enter your numbers: ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int min = MinNumber(arr[0], arr[1], arr[2], arr[3]);
        Console.WriteLine(min);
    }

    static int MinNumber(int a, int b, int c, int d){
        int min = a;

        if (b < min) min = b;
        if (c < min) min = c;
        if (d < min) min = d;

        return min;
    }

}