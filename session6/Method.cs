class Method
{
    /// <summary>
    /// Hàm kiểm tra số nguyên tố
    /// </summary>
    /// <param name="number">giá trị nhập vào</param>
    /// <returns>true : là số nguyên tố. false: không là số nguyên tố</returns>
    public static bool checkPrime(int number)
    {
        if (number <= 2)
        {
            return false;
        }
        for (int i = 2; i < Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static void veTamGiac(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}