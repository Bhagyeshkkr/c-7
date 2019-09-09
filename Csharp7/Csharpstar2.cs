using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp7
{
    // C# program to count the 
    // number of ways to reach 
    // n'th stair 
    

    class GFG
    {
        // A simple recursive 
        // program to find n'th 
        // fibonacci number 
        static int fib(int n)
        {
            if (n <= 1)
                return n;
            return fib(n - 1) +
                fib(n - 2);
        }

        // Returns number of ways 
        // to reach s'th stair 
        static int countWays(int s)
        {
            return fib(s + 1);
        }

        // Driver Code  
        static public void Main()
        {
            int s = 4;
            Console.WriteLine("Number of ways = " +
                                    countWays(s));
            Console.ReadLine();
        }
    }

    // This code is contributed 
    // by akt_mit 

}