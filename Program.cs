using System;

namespace Delegate
{
    public delegate void AddDelegate(int x, int y);
    public delegate string HelloDelegate(string s);
    class Program
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static string hello(string name)
        {
            return ("Hello" + name);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            AddDelegate obj1 = new AddDelegate(p.add);
            HelloDelegate obj2 = new HelloDelegate(hello);
            obj1(100, 50);
            //or
            obj1.Invoke(100, 20);

            Console.WriteLine(obj2("Vishal"));
            Console.WriteLine(obj2.Invoke("Abhay"));
        }
    }
}
