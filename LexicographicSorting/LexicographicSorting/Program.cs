internal class Program
{
    static void Main()
    {
        var words = new string[] { "timofey", "dog", "123", "banana", "aapple", "a" };
        Sort(words);
        Print(words);
    }
    static void Print(string[] words)
    {
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }

    static void Sort(string[] words)
    {
        for (int i = 0; i < words.Length - 1; i++)
        {
            for (int j = i + 1; j < words.Length; j++)
            {
                if (CompareWords(words[i], words[j]) > 0)
                {
                    string temp = words[i];
                    words[i] = words[j];
                    words[j] = temp;
                }
            }
        }
    }
    static int CompareWords(string word1, string word2)
    {
        int minLength = Math.Min(word1.Length, word2.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (word1[i] < word2[i])
            {
                return -1;
            }
            else if (word1[i] > word2[i])
            {
                return 1;
            }
        }

        if (word1.Length < word2.Length)
        {
            return -1;
        }
        else if (word1.Length > word2.Length)
        {
            return 1;
        }

        return 0;
    }
}