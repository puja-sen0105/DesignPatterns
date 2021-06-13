using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IteratorTraveral();
            Console.ReadLine();
        }

        public static void IteratorTraveral()
        {
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse traversal:");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
