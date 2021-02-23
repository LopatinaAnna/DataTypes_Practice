using System;
using System.Diagnostics;
using System.Text;

namespace Strings_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter string: ");
            //var inputString = Console.ReadLine();
            //var stringBuilder = new StringBuilder(inputString);

            //Console.Write("\nEnter char for removing: ");
            //var charToRemove = Console.ReadLine();

            var inputString = "Although StringBuilder and String both represent sequences of characters, they are implemented " +
                "differently. String is an immutable type. That is, each operation that appears to modify a String object actually " +
                "creates a new string. For example, the call to the String.Concat method in the following C# example appears " +
                "to change the value of a string variable named value. In fact, the Concat method returns a value object that has " +
                "a different value and address from the value object that was passed to the method. For routines that perform " +
                "extensive string manipulation (such as apps that modify a string numerous times in a loop), modifying a string " +
                "repeatedly can exact a significant performance penalty. The alternative is to use StringBuilder, which is " +
                "a mutable string class. Mutability means that once an instance of the class has been created, it can be modified " +
                "by appending, removing, replacing, or inserting characters. A StringBuilder object maintains a buffer to " +
                "accommodate expansions to the string. New data is appended to the buffer if room is available; otherwise, " +
                "a new, larger buffer is allocated, data from the original buffer is copied to the new buffer, and the new " +
                "data is then appended to the new buffer. Although StringBuilder and String both represent sequences of characters, they are " +
                "implemented differently. String is an immutable type. That is, each operation that appears to modify a String object " +
                "actually creates a new string. For example, the call to the String.Concat method in the following C# example appears " +
                "to change the value of a string variable named value. In fact, the Concat method returns a value object that has " +
                "a different value and address from the value object that was passed to the method. For routines that perform " +
                "extensive string manipulation (such as apps that modify a string numerous times in a loop), modifying a string " +
                "repeatedly can exact a significant performance penalty. The alternative is to use StringBuilder, which is " +
                "a mutable string class. Mutability means that once an instance of the class has been created, it can be modified " +
                "by appending, removing, replacing, or inserting characters. A StringBuilder object maintains a buffer to " +
                "accommodate expansions to the string. New data is appended to the buffer if room is available; otherwise, " +
                "a new, larger buffer is allocated, data from the original buffer is copied to the new buffer, and the new " +
                "data is then appended to the new buffer. Although StringBuilder and String both represent sequences of characters, they are " +
                "implemented differently. String is an immutable type. That is, each operation that appears to modify a String object " +
                "actually creates a new string. For example, the call to the String.Concat method in the following C# example appears " +
                "to change the value of a string variable named value. In fact, the Concat method returns a value object that has " +
                "a different value and address from the value object that was passed to the method. For routines that perform " +
                "extensive string manipulation (such as apps that modify a string numerous times in a loop), modifying a string " +
                "repeatedly can exact a significant performance penalty. The alternative is to use StringBuilder, which is " +
                "a mutable string class. Mutability means that once an instance of the class has been created, it can be modified " +
                "by appending, removing, replacing, or inserting characters. A StringBuilder object maintains a buffer to " +
                "accommodate expansions to the string. New data is appended to the buffer if room is available; otherwise, " +
                "a new, larger buffer is allocated, data from the original buffer is copied to the new buffer, and the new " +
                "data is then appended to the new buffer.";

            var stringBuilder = new StringBuilder(inputString);
            var charToRemove = "a";

            var timer = new Stopwatch();

            timer.Start();
            inputString = inputString.Replace(charToRemove, string.Empty);
            timer.Stop();

            Console.WriteLine($"String: {Math.Round(timer.Elapsed.TotalMilliseconds, 3)} ms");
            //Console.WriteLine(inputString);

            Console.WriteLine($"\nStringBuilder before length: {stringBuilder.Length}, capacity: {stringBuilder.Capacity}");

            timer.Restart();
            stringBuilder.Replace(charToRemove, string.Empty);
            timer.Stop();

            Console.WriteLine($"StringBuilder after length: {stringBuilder.Length}, capacity: {stringBuilder.Capacity}");
            Console.WriteLine($"StringBuilder: {Math.Round(timer.Elapsed.TotalMilliseconds, 3)} ms");
            //Console.WriteLine(stringBuilder);
        }
    }
}
