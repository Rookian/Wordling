namespace Wordling
{
    public class RandomizeWordChanger : IWordChanger
    {
        public string Randomize(string word)
        {
            var charArray = word.ToCharArray();
            charArray.Shuffle();

            return string.Join(string.Empty, charArray);
        }
    }
}