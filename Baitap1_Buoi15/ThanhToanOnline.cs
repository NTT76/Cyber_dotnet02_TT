using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class ThanhToanOnline : IThanhToan
{
    public bool check = false;
    private int number;
    public int Number(int value)
    {
        this.number = value;
        return this.number;
    }
    public ThanhToanOnline(double price)
    {
    }
    public void thanhToan(double price)
    {
        while (true)
        {
            Console.WriteLine("Nhập mã OTP: ");
            int oTP = Convert.ToInt32(Console.ReadLine());
            if (oTP == number)
            {
                Console.WriteLine("Thanh toán thành công.");
                check = true;
                break;
            }
            else { Console.WriteLine("Mã OTP không chính xác. Mời nhập lại."); }
        }
    }
}