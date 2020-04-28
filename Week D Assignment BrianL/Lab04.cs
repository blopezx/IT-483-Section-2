//Brian Lopez IT 483 Section 2 Suboh
using System;

namespace Lab04
{
    class overloadProgram
    {
        
        static void Main(string[] args)
        {
           int a = 1, b = 3, c = 5;
           double x = 2.2, y = 4.4, z = 6.6, ans;

           ans = average(a, b);
           Console.WriteLine("\naverage(a, b) = " + ans);

           ans = average(a, b, c);
           Console.WriteLine("\naverage(a, b, c) = " + ans);

           ans = average(x, y);
           Console.WriteLine("\naverage(x, y) = " + ans);

           ans = average(x, y, z);
           Console.WriteLine("\naverage(x, y, z) = " + ans);
        }

        static double average(double n1, double n2)
        {
            return (n1 + n2) / 2.0;
        }
        static int average(int n1, int n2)
        {
            return (n1 + n2) / 2;
        }
        static double average(double n1, double n2, double n3)
        {
            return (n1 + n2 + n3) / 3.0;
        }
        static int average(int n1, int n2, int n3)
        {
            return (n1 + n2 + n3) / 3;
        }
    }
}
// The int parameter versions of average are not needed as the double type encompasses ints.
// Similar thing to the question above the double type is able to encompass the int type.
// It is legal as double can encompass an int.