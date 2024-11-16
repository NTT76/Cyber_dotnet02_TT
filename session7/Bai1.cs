using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.XPath;
using Microsoft.VisualBasic;

class Bai1
{
    #region
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
    #endregion

    public static int timMax(List<int> numbers)
    {
        int max = 0;
        foreach (int i in numbers)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
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

    public static string inChuSoNgTo(string input)
    {
        long number = Convert.ToInt64(input);
        long formatNumber = 0;
        while (number > 0)
        {
            long i = number % 10;
            number = number / 10;
            formatNumber = formatNumber * 10 + i;
        }
        string result = "";
        List<long> ints = new List<long>();
        while (formatNumber > 0)
        {
            Boolean check = true;
            long i = formatNumber % 10;
            formatNumber /= 10;
            if (i < 2)
            {
                break;
            }
            for (long count = 2; count <= Math.Sqrt(i); count++)
            {
                if (i % count == 0)
                {
                    check = false;
                    break;
                }
            }
            if (ints.Contains(i) == false && check == true) ints.Add(i);
        }
        if (ints.Count == 0)
        {
            result = "There are no prime numbers";
            Console.WriteLine(result);
        }
        else
        {
            foreach (long x in ints)
            {
                Console.Write($"{x} ");
            }
        }
        return result;
    }

    public static string Prime(int n)
    {
        string result = "";
        for (int i = 2; i <= n; i++)
        {
            bool check = true;
            if (i == 2 || i == 3)
            {
                Console.Write($"{i} ");
                continue;
            }
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    check = false;
                    break;
                }
            }
            if (check == true)
            {
                Console.Write($"{i} ");
            }
        }
        return result;
    }

    public static string doDaiTuCuoiChuoi(string s)
    {
        string str = " ";
        string result = "";
        int index = s.LastIndexOf(" ");
        if (index == -1)
        {
            Console.WriteLine("0");
        }
        else
        {
            result = s.Substring(index + 1);
            Console.WriteLine($"{result.Length}");
        }
        return str;
    }

    public static string tachChuoi(string value)
    {
        string str = " ";
        int index = 0;
        string[] strings = value.Split(' ');
        int max = 0;
        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i].Length > max)
            {
                max = strings[i].Length;
                index = i;
            }
        }
        str = strings[index];
        Console.WriteLine(str);
        return str;
    }

    public static string xoaKyTu(string value)
    {
        string result = "";
        for (int i = 0; i < value.Length; i++)
        {
            if ((value[i] >= '0' && value[i] <= '9') || (value[i] >= 'a' && value[i] <= 'z') || (value[i] >= 'A' && value[i] <= 'Z') || (value[i] == ' '))
            {
                result += value[i];
            }
        }
        Console.WriteLine(result);
        return result;
    }

    public static string tachChuoiCoSo(string value)
    {
        List<string> list = new List<string>();
        int max = 0;
        bool check = false;
        string[] str = value.Split(' ');
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < str[i].Length; j++)
            {
                if (str[i][j] >= '0' && str[i][j] <= '9')
                {
                    check = true;
                    list.Add(str[i]);
                    break;
                }
            }
        }
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Length > max)
            {
                max = list[i].Length;
            }
        }
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Length == max)
            {
                Console.WriteLine($"{list[i]}");
                return list[i];
            }
        }
        return null;
    }

    public static string reverse(string s)
    {
        string result = string.Empty;
        List<string> list = new List<string>();
        string[] str = s.Split(' ');
        for (int i = 0; i < str.Length; i++)
        {
            string reverse = string.Empty;
            for (int j = str[i].Length - 1; j >= 0; j--)
            {
                reverse += str[i][j];
            }
            list.Add(reverse);
        }
        result = string.Join(" ", list);
        Console.WriteLine($"{result}");
        return result;
    }
}
