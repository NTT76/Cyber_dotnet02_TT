using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class Bai1
{
    public static int Sum(List<int> list)
    {
        int sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            sum += list[i];
        }
        return sum;
    }

    public static List<int> twoSum(List<int> lst, int target)
    {
        for (int i = 0; i < lst.Count; i++)
        {
            for (int j = i + 1; j < lst.Count; j++)
            {
                if (lst[i] + lst[j] == target)
                {
                    return new List<int> { i, j };
                }
            }
        }
        return null;
    }

    public static List<int> listDuyNhat(List<int> numbers)
    {
        List<int> resultList = new List<int>();
        foreach (int n in numbers)
        {
            if (resultList.Contains(n) == false) { resultList.Add(n); }
        }
        return resultList;
    }

    public static List<int> xoaTrungLap(List<int> numbers, int n)
    {
        List<int> lst = new List<int>();
        Dictionary<int, int> d = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            int ints = numbers[i];
            int dem = 0;
            foreach (int m in numbers)
            {
                if (m == ints)
                {
                    dem++;
                }
            }
            if (d.ContainsKey(ints) == false)
            {
                d.Add(ints, dem);
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (d.Values.ElementAt(i) > d.Values.ElementAt(i + 1))
            {
                lst.Add(d.Keys.ElementAt(i));
            }
        }
        return lst;
    }

    public static int bestTime(List<int> lst)
    {
        List<int> ints = new List<int>();
        int max = 0;
        for (int i = 0; i < lst.Count; i++)
        {
            for (int j = 0; j < lst.Count; j++)
            {
                int giaTri = lst[j] - lst[i];
                ints.Add(giaTri);
            }
        }
        for (int i = 0; i < ints.Count; i++)
        {
            if (max < ints.ElementAt(i))
            {
                max = ints.ElementAt(i);
            }
        }
        return max;
    }
}