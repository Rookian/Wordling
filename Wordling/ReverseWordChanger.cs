using System.Globalization;
using System.Linq;

namespace Wordling
{
    public class ReverseWordChanger : IWordChanger
    {
        public string Randomize(string word)
        {
            return string.Join(string.Empty, word.ToCharArray().Select(x => x.ToString(CultureInfo.InvariantCulture)).Reverse());
        }
    }
}