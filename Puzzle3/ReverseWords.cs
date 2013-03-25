namespace Puzzle3
{
    public class ReverseWords
    {
        static public string Reverse (string input)
        {
            var word = "";
            var output = "";

            foreach (var c in input)
            {
                if (c != ' ')
                {
                    word = c + word;
                }
                else
                {
                    output += word + ' ';
                    word = "";
                }
            }

            if (word.Length > 0)
            {
                output += word;
            }

            return output.Trim();
        }
    }
}