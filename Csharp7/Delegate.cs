﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp7
//{
//   public class Delegate
//    {
//        public delegate void Print(int value);
//        public static void Main()
//        {
//            // Print delegate points to PrintNumber
//            Print printDel = PrintNumber;

//            printDel(100000);
//            printDel(200);

//            // Print delegate points to PrintMoney
//            printDel = PrintMoney;

//            printDel(10000);
//            printDel(200);
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
