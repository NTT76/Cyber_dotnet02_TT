class TwoSum
{
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

    public static List<int> twoSum2(List<int> lst, int target)
    {
        //khai báo Dictionary để đánh dấu từng số trong danh sách lst
        Dictionary<int, int> d = new Dictionary<int, int>();
        for (int i = 0; i < lst.Count; i++)
        {
            int completion = target - lst[i];
            if (d.ContainsKey(completion))
            {
                return new List<int> { d[completion], i };
            }
            else
            {
                d.Add(lst[i], i);
            }
        }
        return null;
    }
}