using System.Security.Authentication;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        #region functions trong List của Collection
        // List<int> numbers = new List<int>();
        // Console.WriteLine("Nhập số phần tử mảng: ");
        // int n = Convert.ToInt32(Console.ReadLine());
        // for (int i = 0; i < n; i++)
        // {
        //     Console.WriteLine($"Nhập số thứ: {i + 1}");
        //     int number = Convert.ToInt32(Console.ReadLine());
        //     numbers.Add(number);
        // }
        // Console.WriteLine("Danh sách phần tử đã nhập là: ");
        // foreach (int number in numbers)
        // {
        //     Console.Write(number);
        // }
        // Console.WriteLine();
        // Console.Write(String.Join(", ", numbers));
        // Console.WriteLine();

        // //Dùng funcion Sort để sắp xếp phần tử của mảng
        // numbers.Sort();
        // Console.WriteLine("Danh sách phần tử đã sắp xếp: ");
        // Console.Write(String.Join(", ", numbers));
        // Console.WriteLine();

        // // Dùng functions Reverse
        // numbers.Reverse();
        // Console.WriteLine("Danh sách phần tử đã reverse: ");
        // Console.Write(String.Join(", ", numbers));
        // Console.WriteLine();
        #endregion

        #region Bài 1: tính tổng các số lớn hơn 50 trong mảng
        //khai báo list phần tử
        // List<int> numbers = new List<int> { 20, 50, 31, 75, 65, 100 };
        // int sum = Bai1.tongSoLon50(numbers);
        // Console.WriteLine($"Tổng các số lớn hơn 50 của mảng là: {sum}");
        #endregion

        #region Bài 2: tìm số lớn nhất
        //khai báo list phần tử
        // List<int> numbers = new List<int> { 20, 50, 31, 75, 65, 100 };
        // int max = Bai1.timMax(numbers);
        // Console.WriteLine($"Số lớn nhất trong mảng là: {max}");
        #endregion

        #region Bài 3: tìm chữ bắt đầu bằng chữ M
        // List<String> strings = new List<String> { "apple", "banana", "orange", "kiwi", "mango", "melon", "Moo" };
        // Console.WriteLine($"Các chứ bắt đầu bằng chữ cái M trong mảng: ");
        // List<String> str = Bai1.timChu(strings);
        // Console.Write(String.Join(", ", str));
        // Console.WriteLine();
        #endregion

        #region Bài 4: loại bỏ trùng nhau
        // List<int> ints = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5 };
        // Console.Write("Mảng sau khi đã loại bỏ phần tử trùng nhau: ");
        // List<int> ints1 = Bai1.listDuyNhat(ints);
        // Console.Write(String.Join(", ", ints1));
        // Console.WriteLine();
        #endregion

        #region Dictionary
        Dictionary<string, string> dic = new Dictionary<string, string>();
        //thêm value
        dic.Add("Nguyễn", "Thìn");
        dic["Trần"] = "Yến";

        //duyệt dictionary
        foreach (KeyValuePair<string, string> pointer in dic)
        {
            // pointer: key-value
            Console.WriteLine($"Họ: {pointer.Key}, Tên: {pointer.Value}");
        }
        //Chỉ duyệt mỗi keey hoặc value ==> y chang bên List
        //Chỉ duyệt key
        //Cách 1:
        Console.WriteLine($"Danh sách test key là: ");
        foreach (string str in dic.Keys)
        {
            Console.WriteLine(str);
        }
        //Cách 2:
        // for (int i = 0; i < dic.Keys.Count; i++)
        // {
        //     Console.WriteLine(dic.Keys.ElementAt(i));
        // }

        // update value cho dic
        dic["Nguyễn"] = "Trọng";
        Console.WriteLine("dic sau khi update: ");
        foreach (KeyValuePair<string, string> kvp in dic)
        {
            Console.WriteLine($"Họ: {kvp.Key}, Tên: {kvp.Value}");
        }

        //xóa key-value trong dic
        dic.Remove("Nguyễn");
        Console.WriteLine("dic sau khi xóa: ");
        foreach (KeyValuePair<string, string> kvp in dic)
        {
            Console.WriteLine($"Họ: {kvp.Key}, Tên: {kvp.Value}");
        }
        #endregion
    }
}