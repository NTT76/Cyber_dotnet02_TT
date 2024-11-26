internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<int> lst = new List<int> { 2, 7, 9, 11, 15 };
        int target = 26;
        // chạy cách 1
        if (TwoSum.twoSum2(lst, target) == null)
        {
            Console.WriteLine($"Không có 2 số nào có tổng bằng {target}");
        }
        else
        {
            List<int> indexs = TwoSum.twoSum2(lst, target);
            Console.WriteLine($"chỉ số 2 số có tổng băng {target} là: {string.Join(",", indexs)}");
        }

        #region khái niệm về cách lưu trữ biến trong máy tính
        int number1 = 10;
        int number2 = number1;
        number1 = 30;
        Console.WriteLine($"number1: {number1}, number2: {number2}");
        #endregion
    }
}