using System;

namespace Wordling
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Wordling");
            Console.WriteLine();
            Console.Write("Text: ");
            var text = Console.ReadLine();
            var letters = new LettersMixer(new RandomizeWordChanger());
            var mixLetters = letters.MixLetters(text);
            Console.WriteLine(mixLetters);
            Console.ReadLine();
        }
    }
}
