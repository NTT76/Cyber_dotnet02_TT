class ThanhToanTienMat : IThanhToan
{
    public bool check = false;
    public ThanhToanTienMat(double price)
    {

    }
    public void thanhToan(double price)
    {
        Console.WriteLine("Thanh toán thành công.");
        check = true;
    }

}