// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment4
{
    /// <summary>
    /// My playing ground. Therefore not commented.
    /// </summary>
    /// <typeparam name="Ty"></typeparam>
    class Sandbox<Ty>
    {
        double f = 3.14;
        public T DoSomething<T>(T obj)
        {
            //code
            return obj;
        }

        void test1()
        {
            var a = DoSomething<int>((int) f);
            var b = DoSomething((int) f);

            string c;
            c = DoSomething(f.ToString());
            c = DoSomething<string>(f.ToString());

            f = DoSomething(Math.PI);
            f = DoSomething<double>(Math.PI);

            var fe = DoSomething(new FormatException());

            var x = new ArrayList();
        }


    }

    public class Generic<T>
    {
        private T field;
        public T Test()
        {
            T i = field;
            // T i = field + 1;  //#1                    
            return i;
        }
    }

    public class MyContainer<T> where T : class, IComparable
    {
        /*Code*/
    }

    class Diverse
    {
        Stack stack = new Stack();

        void f1 ()
        {
            var v = stack.Peek();
            var ht = new Hashtable();
            var di = new Dictionary<int, int>();
            var ba = new BitArray(17);
        }

        public void Test()

        {

            var st = new Stack();
            st.Push("hello");
            st.Push(8.2);
            st.Push(5);
            st.Push('b');
            st.Push(true);
        }
    }
}
