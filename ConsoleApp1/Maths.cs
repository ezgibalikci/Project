using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Maths
    {
       public static int Factorial(int sonuc, int sayi)
        {
            for (int i = 1; i <= sayi; i++)
            {
                sonuc = sonuc * i;
            }
            return sonuc;

        }

        public static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        public static int Fibonacci(int n)
        {
            int fi1 = 1, fi2 = 2;
            if (n == 1)
            {
                return fi1;
            }
            else if (n == 2)
            {

                return fi2;

            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
