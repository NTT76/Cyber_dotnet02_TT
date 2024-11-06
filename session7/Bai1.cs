using Microsoft.VisualBasic;

class Bai1
{
    public static int tongSoLon50(List<int> numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > 50)
            {
                sum += numbers[i];
            }
        }
        return sum;
    }

    public static int timMax(List<int> numbers)
    {
        int max = 0;
        foreach (int i in numbers)
        {
            if (max < i)
            {
                max = i;
            }
        }
        return max;
    }

    public static List<string> timChu(List<String> strings)
    {
        List<string> resultList = new List<string>();
        foreach (String s in strings)
        {
            if (s.Contains("m") || s.Contains("M"))
            {
                resultList.Add(s);
            }
        }
        return resultList;
    }

    public static List<int> listDuyNhat(List<int> numbers)
    {
        List<int> resultList = new List<int>();
        foreach (int n in numbers)
        {
            if (resultList.Contains(n) == false) resultList.Add(n);
        }
        return resultList;
    }
}