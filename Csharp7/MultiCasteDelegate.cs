﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp7
//{
//  public class MultiCasteDelegate
//    {

//        public delegate void Print(int value);

//        public static void Main()
//        {
//            Print printDel = PrintNumber;
//            printDel += PrintHexadecimal;
//            printDel += PrintMoney;

//            printDel(1000);
//            printDel -= PrintHexadecimal;
//            printDel(2000);
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

//        public static void PrintHexadecimal(int dec)
//        {
//            Console.WriteLine("Hexadecimal: {0:X}", dec);
//            Console.ReadLine();
//        }
//    }
//}
