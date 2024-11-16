internal class Program
{
    private static void Main(string[] args)
    {
        //Bài 1:
        List<int> numbers = new List<int> { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
        int sum = Bai1.Sum(numbers);
        Console.WriteLine($"Tổng các thành phần mảng là: {sum}");

        //Bài 2:
        List<int> numbers2 = new List<int> { 2, 7, 11, 15 };
        int target = 9;
        // chạy cách 1
        if (Bai1.twoSum(numbers2, target) == null)
        {
            Console.WriteLine($"Không có 2 số nào có tổng bằng {target}");
        }
        else
        {
            List<int> indexs = Bai1.twoSum(numbers2, target);
            Console.WriteLine($"chỉ số 2 số có tổng băng {target} là: {string.Join(",", indexs)}");
        }

        //Bài 3:
        List<int> ints = new List<int> { 1, 1, 1, 2, 2, 3, 4, 4, 5 };
        Console.Write("Mảng sau khi đã loại bỏ phần tử trùng nhau: ");
        List<int> ints1 = Bai1.listDuyNhat(ints);
        Console.Write(String.Join(", ", ints1));
        Console.WriteLine();

        //Bài 4:
        List<int> ints2 = new List<int> { 1, 1, 1, 2, 2, 3 };
        int k = 2;
        List<int> ints3 = Bai1.xoaTrungLap(ints, k);
        Console.WriteLine($"{k} phần tử xuất hiện nhiều nhất là: {String.Join(", ", ints3)}");

        //Bài 5:
        List<int> ints4 = new List<int> { 7, 1, 5, 3, 6, 4 };
        int ints5 = Bai1.bestTime(ints4);
        Console.WriteLine($"Lợi nhuận lớn nhất mua cổ phiếu là: {ints5}");
    }
}