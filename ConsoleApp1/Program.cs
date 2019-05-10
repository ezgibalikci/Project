using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sonuc=1;
            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write(Maths.Fibonacci(sayi));
            Console.Write(Maths.Factorial(sonuc, sayi));
            Console.Write(Maths.Factorial(sayi));
            Console.ReadKey();
           
        }
       



    }
}
