internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        CuaHang cuaHang = new CuaHang("Trong Thin");

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("--- Hệ thống quản lý bán hàng ---");
            Console.WriteLine("1. Thêm sản phẩm");
            Console.WriteLine("2. Hiển thị danh sách sản phẩm");
            Console.WriteLine("3. Tính tổng doanh thu");
            Console.WriteLine("4. Xóa sản phẩm");
            Console.WriteLine("5. Thoát");
            Console.WriteLine("Vui lòng chọn chức năng:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Chọn loại sản phẩm: ");
                    Console.WriteLine("1. Điện tử");
                    Console.WriteLine("2. Thời trang");
                    Console.WriteLine("3. Thực phẩm");
                    Console.WriteLine("Lựa chọn: ");
                    int i = Convert.ToInt32(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            Console.WriteLine("Nhập mã sản phẩm: ");
                            string maSP = Console.ReadLine();
                            Console.WriteLine("Nhập tên sản phẩm: ");
                            string tenSP = Console.ReadLine();
                            Console.WriteLine("Nhập giá gốc: ");
                            double giaGoc = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Nhập thuế bảo hành (%): ");
                            double thue = Convert.ToInt32(Console.ReadLine());
                            SanPham sanPham = new DienTu(maSP, tenSP, giaGoc, thue);
                            cuaHang.themSP(sanPham);
                            cuaHang.ghiDuLieu();
                            break;
                        case 2:
                            Console.WriteLine("Nhập mã sản phẩm: ");
                            string maSP2 = Console.ReadLine();
                            Console.WriteLine("Nhập tên sản phẩm: ");
                            string tenSP2 = Console.ReadLine();
                            Console.WriteLine("Nhập giá gốc: ");
                            double giaGoc2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Nhập giảm giá (%): ");
                            double uuDai = Convert.ToInt32(Console.ReadLine());
                            SanPham sanPham2 = new ThoiTrang(maSP2, tenSP2, giaGoc2, uuDai);
                            cuaHang.themSP(sanPham2);
                            cuaHang.ghiDuLieu();
                            break;
                        case 3:
                            Console.WriteLine("Nhập mã sản phẩm: ");
                            string maSP3 = Console.ReadLine();
                            Console.WriteLine("Nhập tên sản phẩm: ");
                            string tenSP3 = Console.ReadLine();
                            Console.WriteLine("Nhập giá gốc: ");
                            double giaGoc3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Nhập phí vận chuyển: ");
                            double phi = Convert.ToInt32(Console.ReadLine());
                            SanPham sanPham3 = new ThucPham(maSP3, tenSP3, giaGoc3, phi);
                            cuaHang.themSP(sanPham3);
                            cuaHang.ghiDuLieu();
                            break;
                    }
                    break;
                case 2:
                    cuaHang.hienThiDanhSachSP();
                    break;
                case 3:
                    cuaHang.tongDoanhThu();
                    break;
                case 4:
                    Console.WriteLine("Nhập mã sản phẩm cần xóa: ");
                    string id = Console.ReadLine();
                    cuaHang.xoaSP(id);
                    break;
                case 5: return;
                default:
                    Console.WriteLine("Vui lòng chọn chức năng (1-5):  ");
                    break;
            }
        }
    }
}