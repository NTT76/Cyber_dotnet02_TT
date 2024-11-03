internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        #region kiểm tra số nguyên tố
        // Console.WriteLine("Mời bạn nhập số: ");
        // string? number = Console.ReadLine();
        // int formatNumber = Convert.ToInt32(number);
        // bool isPrime = Method.checkPrime(formatNumber);
        // if (isPrime == true)
        // {
        //     Console.WriteLine($"Số {number} là số nguyên tố");
        // }
        // else
        // {
        //     Console.WriteLine($"Số {number} không là số nguyên tố");
        // }
        #endregion

        #region vẽ tam giác vuông
        // Console.WriteLine("Mời nhập độ dài cạnh: ");
        // int number2 = Convert.ToInt32(Console.ReadLine());
        // Method.veTamGiac(number2);
        #endregion

        #region Collection trong c#
        // data structure
        // List 
        List<int> number = new List<int>();

        //define giá trị ban đầu
        List<string> names = new List<string> { "thìn", "Yến", "huyền", "thủy", "quỳnh" };
        //                           index          0       1       2       3        4
        //                         reverseIndex     ^5      ^4      ^3      ^2      ^1
        Console.WriteLine($"Phần tử thứ 2 là: {names[2]}");
        Console.WriteLine($"Phần tử nghịch đảo là: {names[^3]}");
        Console.WriteLine(names);
        //Lưu ý: WriteLine chỉ in được giá trị cho những dữ liệu nguyên thủy: int, float, double, string..
        // Còn kiểu dữ liệu Collections thì chỉ in ra địa chỉ vùng nhớ của biến đó
        Console.Write(String.Join(", ", names));
        Console.WriteLine();
        #endregion

        #region bài tập nhập n phần tử xuất ra n phần tử
        Console.WriteLine("Nhập số lượng phần tử: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        //tạo biến chứa danh sách phần tử
        List<int> listNumbers = new List<int>();
        for (int i = 0; i < number2; i++)
        {
            //cách 1: insert
            Console.WriteLine("nhập phần tử thứ: " + i);
            int item = Convert.ToInt32(Console.ReadLine());
            listNumbers.Insert(i, item);
        }
        //in list phần tử ra ngoài màn hình
        Console.WriteLine("Danh sách phần tử: ");
        //cách 1: for
        // for (int i = 0; i < listNumbers.Count; i++)
        // {
        //     Console.WriteLine(listNumbers[i]);
        // }
        //Cách 2: foreach
        foreach (int i in listNumbers)
        {
            Console.WriteLine(listNumbers[i]);
        }
        #endregion
    }
}