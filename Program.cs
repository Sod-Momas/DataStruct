using System;

namespace DataStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> list = new LinkedList<int>();
            list.add(5);
            list.add(4);
            list.add(3);
            list.add(2);
            list.add(1);
            list.printAll();
        }
    }
}
