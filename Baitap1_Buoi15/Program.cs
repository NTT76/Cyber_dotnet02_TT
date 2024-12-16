internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        LichSuThanhToan lichSuThanhToan = new LichSuThanhToan("A1");
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("====== Hệ Thống Thanh Toán =====");
            Console.WriteLine("1. Thanh toán bằng tiền mặt.");
            Console.WriteLine("2. Thanh toán bằng thẻ.");
            Console.WriteLine("3. Thanh toán online.");
            Console.WriteLine("4. Xem lịch sử giao dịch.");
            Console.WriteLine("5. Thoát.");
            Console.WriteLine("Chọn phương thức thanh toán: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            IThanhToan xuLyThanhToan = null;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Nhập mã sản phẩm cần thanh toán: ");
                    string maSP = Console.ReadLine();
                    Console.WriteLine("Nhập tên sản phẩm cần thanh toán: ");
                    string tenSP = Console.ReadLine();
                    Console.WriteLine("Nhập số tiền cần thanh toán: ");
                    double giaSP = Convert.ToDouble(Console.ReadLine());
                    SanPham sanPham = new SanPham(maSP, tenSP, giaSP);
                    ThanhToanTienMat thanhToanTienMat = new ThanhToanTienMat(giaSP);
                    thanhToanTienMat.thanhToan(giaSP);
                    lichSuThanhToan.lichSu(sanPham, thanhToanTienMat.check);
                    break;
                case 2:
                    Console.WriteLine("Nhập mã sản phẩm cần thanh toán: ");
                    string maSP2 = Console.ReadLine();
                    Console.WriteLine("Nhập tên sản phẩm cần thanh toán: ");
                    string tenSP2 = Console.ReadLine();
                    Console.WriteLine("Nhập số tiền cần thanh toán: ");
                    double giaSP2 = Convert.ToDouble(Console.ReadLine());
                    SanPham sanPham2 = new SanPham(maSP2, tenSP2, giaSP2);
                    ThanhToanBangThe thanhToanBangThe = new ThanhToanBangThe(giaSP2);
                    thanhToanBangThe.thanhToan(giaSP2);
                    lichSuThanhToan.lichSu(sanPham2, thanhToanBangThe.check);
                    break;
                case 3:
                    Console.WriteLine("Nhập mã sản phẩm cần thanh toán: ");
                    string maSP3 = Console.ReadLine();
                    Console.WriteLine("Nhập tên sản phẩm cần thanh toán: ");
                    string tenSP3 = Console.ReadLine();
                    Console.WriteLine("Nhập số tiền cần thanh toán: ");
                    double giaSP3 = Convert.ToDouble(Console.ReadLine());
                    SanPham sanPham3 = new SanPham(maSP3, tenSP3, giaSP3);
                    Random rand = new Random();
                    int number = rand.Next(1000, 9999);
                    Console.WriteLine($"Mã OTP: {number}");
                    ThanhToanOnline thanhToanOnline = new ThanhToanOnline(giaSP3);
                    thanhToanOnline.Number(number);
                    thanhToanOnline.thanhToan(giaSP3);
                    lichSuThanhToan.lichSu(sanPham3, thanhToanOnline.check);
                    break;
                case 4:
                    lichSuThanhToan.ghiDuLieu();
                    lichSuThanhToan.hienThiLichSu();
                    break;
                case 5: return;
                default:
                    Console.WriteLine("Chọn chức năng (1-5): ");
                    break;
            }
        }
    }
}