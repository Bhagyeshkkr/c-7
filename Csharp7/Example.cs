//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp7
//{
//    public class Stack
//    {
//        Entry top;
//        public void Push(object data)
//        {
//            top = new Entry(top, data);
//        }

//        public object Pop()
//        {
//            if (top == null)
//            {
//                throw new InvalidOperationException();
//            }
//            object result = top.data;
//            top = top.next;
//            return result;
//        }

//        class Entry
//        {
//            public Entry next;
//            public object data;
//            public Entry(Entry next, object data)
//            {
//                this.next = next;
//                this.data = data;
//            }
//        }
//    }

//    public class Example
//    {
//        static void Main()
//        {
//            Stack s = new Stack();
//            s.Push(1);
//            s.Push(10);
//            s.Push(100);
//            Console.WriteLine(s.Pop());
//            Console.WriteLine(s.Pop());
//            Console.WriteLine(s.Pop());
//            Console.ReadLine();
//        }
//    }

//}