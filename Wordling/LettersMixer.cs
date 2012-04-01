using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Wordling
{
    public class LettersMixer
    {
        private readonly IWordChanger _wordChanger;

        public LettersMixer(IWordChanger wordChanger)
        {
            _wordChanger = wordChanger;
        }

        public string MixLetters(string text)
        {
            var words = text.Split(String.Empty.ToCharArray());
            var list = new List<string>();
            foreach (var word in words)
            {
                var last = word.Contains(",") || word.Contains(".") ? 3 : 2;
                var originalInnerWord = String.Join(String.Empty, word.Skip(1).Take(word.Count() - last).Select(x => x.ToString(CultureInfo.InvariantCulture)));

                var scrambledInnerWord = _wordChanger.Randomize(originalInnerWord);
                list.Add(originalInnerWord == string.Empty ? word : word.Replace(originalInnerWord, scrambledInnerWord));
            }
            return string.Join(" ", list);
        }
    }
}