internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //gọi hàm
        int ketQua = tinhTong(2, 5);

        Console.WriteLine(ketQua);

        Console.WriteLine("nhập số n: ");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i <= number; i++)
        {
            bool isPrime = check(i);
            if (isPrime == true)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();

        Console.WriteLine("nhập số kiểm tra đối xứng ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        int reverseNumber = soDaoNguoc(number2);
        if (reverseNumber == number2)
        {
            Console.WriteLine($"{number2} là số đối xứng");
        }
        else
        {
            Console.WriteLine($"{number2} không là số đối xứng");
        }
    }

    //Khai báo hàm kiểm tra đối xứng
    private static int soDaoNguoc(int number2)
    {
        int originalNumber = number2;
        int soDoiXung = 0;
        while (number2 > 0)
        {
            int lastDigit = number2 % 10;
            soDoiXung = soDoiXung * 10 + lastDigit;
            number2 = number2 / 10;
        }
        return soDoiXung;
    }

    //khai báo hàm kiểm tra số nguyên tố
    private static bool check(int number)
    {
        if (number <= 2)
        {
            return false;
        }
        for (int count = 2; count <= Math.Sqrt(number); count++)
        {
            if (number % count == 0)
            {
                return false;
            }
        }
        return true;
    }

    //khai báo hàm tính tổng
    private static int tinhTong(int x, int y)
    {
        return x + y;
    }


}