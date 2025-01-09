using System;
class Program{
    static void Main(){
        Console.Write("Enter your number: ");
        int x = int.Parse(Console.ReadLine());

        Divisors(x);
    }

    static void Divisors(int x){
        for (int i=1; i<=x; i++){
            if (x%i==0){
                Console.Write(i + " ");
            }
        }
    }

}