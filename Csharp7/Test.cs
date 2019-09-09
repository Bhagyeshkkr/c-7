//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp7
//{
//    public class Test
//    {
//        //public static void Main()
//        //{
//        //    MyGenericClass<string> strGenericClass = new MyGenericClass<string>("Hello Generic World");

//        //    strGenericClass.genericProperty = "This is a generic property example.";
//        //    string result = strGenericClass.genericMethod("Generic Parameter");
//        //}
//      public static void Main()
//        {
//            //int i = 10;

//            //bool result = i.IsGreaterThan(500);

//            //Console.WriteLine(result);
//            //Console.ReadLine();
//            int result = 10.MultiplyBy(2).MultiplyBy(2);
//            Console.WriteLine(result);
//            Console.ReadLine();
//        }
//    }
//    public class MyGenericClass<T>
//    {
//        private T genericMemberVariable;

//        public MyGenericClass(T value)
//        {
//            genericMemberVariable = value;
//        }

//        public T genericMethod(T genericParameter)
//        {
//            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
//            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);
//            Console.ReadLine();

//            return genericMemberVariable;
//        }

//        public T genericProperty { get; set; }
//    }
//    public static class IntExtensions
//    {
//        //public static bool IsGreaterThan(this int i, int value)
//        //{
//        //    return i > value;
//        //}
//        public static int MultiplyBy(this int value, int mulitiplier)
//        {
//            // Uses a second parameter after the instance parameter.
//            return value * mulitiplier;
//        }
//    }
//}
