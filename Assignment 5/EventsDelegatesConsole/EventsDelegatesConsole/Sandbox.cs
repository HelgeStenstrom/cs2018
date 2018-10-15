using System;
using System.Globalization;

namespace EventsDelegatesConsole
{
    public class Sandbox
    {
        private double c;

        public T DoSomething<T>(T obj)
        {
            return obj;
        }

        void f()
        {
            int a;
            a = DoSomething<int>((int) c);
            a = DoSomething((int) c);

            string b = DoSomething<string>(c.ToString());

            
            c = DoSomething(Math.PI);
            c = DoSomething<double>(Math.PI);
        }
    }
    
    
}