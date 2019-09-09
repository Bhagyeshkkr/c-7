//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp7
//{
//    public class Delegate1
//    {

//        public delegate void Print(int value);

//        public static void Main()
//        {
//            PrintHelper(PrintNumber, 10000);
//            PrintHelper(PrintMoney, 10000);
//        }

//        public static void PrintHelper(Print delegateFunc, int numToPrint)
//        {
//            delegateFunc(numToPrint);
//        }

//        public static void PrintNumber(int num)
//        {
//            Console.WriteLine("Number: {0,-12:N0}", num);
//            Console.ReadLine();
//        }

//        public static void PrintMoney(int money)
//        {
//            Console.WriteLine("Money: {0:C}", money);
//            Console.ReadLine();
//        }
//    }
//}
