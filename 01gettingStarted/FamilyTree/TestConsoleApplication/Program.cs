using System;
using Core;

namespace TestConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, we going to listing the tree nodes names");

            ElementsProvider elementsProvider = new ElementsProvider();

            foreach(Element element in elementsProvider.Elements)
            {
                Console.WriteLine("Element name : " + element.Name);
            }

            Console.ReadKey();

        }
    }
}
