using System;
using System.IO;
using System.Linq;

namespace File_Text_Displayer
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"Insert txt file pathway here";
            var words = File.ReadAllText(path).Split(" ");
            var numOfWords = words.Count();
            Console.WriteLine(numOfWords);

        }
    }
}
