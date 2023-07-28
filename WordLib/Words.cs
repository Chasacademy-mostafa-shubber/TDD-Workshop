namespace WordLib
{
    public class Words
    {

        public  string Palindrome(string words)
        {

            string reversString = string.Empty;
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversString += words[i];
            }

            return reversString;
        }

        public int CountLetters(string words)
        {
            int NumberOfLenght = words.Length;

            return NumberOfLenght;
        }
    }
}