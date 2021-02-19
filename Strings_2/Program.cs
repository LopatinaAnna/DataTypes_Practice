using System;
using System.Diagnostics;
using System.Text;

namespace Strings_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("First string: ");
            //var first = Console.ReadLine();
            //var firstSB = new StringBuilder(first);

            //Console.Write("\nSecond string: ");
            //var second = Console.ReadLine();

            var first = "String is an immutable type. That is, each operation that appears " +
                "to modify a String object actually creates a new string.";

            var second = "Although StringBuilder and String both represent sequences of characters, " +
                "they are implemented differently.";

            var firstSB = new StringBuilder(first);

            var timer = new Stopwatch();

            timer.Start();
            first = first.Insert(0, second);
            timer.Stop();

            Console.WriteLine($"String: {timer.Elapsed.TotalMilliseconds} ms");
            Console.WriteLine(first);

            timer.Restart();
            firstSB.Insert(0, second);
            timer.Stop();

            Console.WriteLine($"\nStringBuilder: {timer.Elapsed.TotalMilliseconds} ms");
            Console.WriteLine(firstSB);
        }
    }
}
