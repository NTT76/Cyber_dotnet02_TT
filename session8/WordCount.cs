class WordCount
{
    public static Dictionary<string, int> wordCount(List<string> words)
    {
        Dictionary<string, int> count = new Dictionary<string, int>();
        //Cách 1: duyệt for theo index
        for (int i = 0; i < words.Count; i++)
        {
            if (count.ContainsKey(words[i]))
            {
                count[words[i]]++;
            }
            else
            {
                count[words[i]] = 1;
            }
        }
        //Cacsh2: duyệt for theo item
        foreach (string word in words)
        {
            if (count.ContainsKey(word))
            {
                count[word]++;
            }
            else
            {
                count[word] = 1;
            }
        }
        return count;
    }
}