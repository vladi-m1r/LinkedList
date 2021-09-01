using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> nameList = new LinkedList<string>();
            nameList.add("Vladimir");
            nameList.add("Lain");
            nameList.add("Moon");
            nameList.add("Star");
            nameList.add("Delusion");

            Console.WriteLine($"List size: {nameList.Size}");

            while(!nameList.isEmpty()){
                Console.WriteLine(nameList.getHeadValue());
                nameList.next();
            }
        }
    }
}
