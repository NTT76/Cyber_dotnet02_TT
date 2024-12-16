class ThanhToanBangThe : IThanhToan
{
    int maPIN = 1806;
    public bool check = false;
    public ThanhToanBangThe(double price)
    {
    }
    public void thanhToan(double price)
    {
        while (true)
        {
            Console.WriteLine("Nhập mã PIN (1806): ");
            int PIN = Convert.ToInt32(Console.ReadLine());
            if (PIN == maPIN)
            {
                Console.WriteLine("Thanh toán thành công.");
                check = true;
                break;
            }
            else { Console.WriteLine("Mã OTP không chính xác. Mời nhập lại."); }
        }
    }
}