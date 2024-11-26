class DoanVan
{
    public static void process()
    {
        Console.WriteLine("Mời bạn nhập đoạn văn: ");
        string text = Console.ReadLine();

        //B1: Tách từ:
        string[] words = text.Split(new[] { ' ', ',', '.', '?', '!' });

        //b2: như session8
        Dictionary<string, int> wordCounts = new Dictionary<string, int>();
        foreach (string word in words)
        {
            //chuyển các từ về viết thường.
            string lowerWord = word.ToLower();
            if (wordCounts.ContainsKey(lowerWord))
            {
                wordCounts[lowerWord]++;
            }
            else
            {
                wordCounts[lowerWord] = 1;
            }
        }
        Console.WriteLine("Số lần xuất hiện từng từ là: ");
        foreach (KeyValuePair<string, int> kvp in wordCounts)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}