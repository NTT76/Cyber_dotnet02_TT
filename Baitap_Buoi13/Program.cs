using Newtonsoft.Json;
internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("1. Quản lý học sinh");
            Console.WriteLine("2. Quản lý sản phẩm - đơn hàng");
            Console.WriteLine("Lựa chọn truy cập: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Classroom classroom = new Classroom("C02", "Dotnet02");
                while (true)
                {
                    Console.WriteLine("1. Thêm thông tin");
                    Console.WriteLine("2. Tra thông tin");
                    Console.WriteLine("3. Câp nhật điểm số");
                    Console.WriteLine("4. Tính điểm TB và xếp loại học lực");
                    Console.WriteLine("5. Xóa học sinh khỏi danh sách");
                    Console.WriteLine("6. Hiển thị danh sách học sinh và học lực: ");
                    Console.WriteLine("7. Danh sách học sinh theo điểm trung bình: ");
                    Console.WriteLine("8. Hiển thị học sinh theo tên: ");
                    Console.WriteLine("9. Đọc ghi dữ liệu từ file json: ");
                    Console.WriteLine("10. Thoát");
                    Console.WriteLine("Mời bạn chọn 1 chức năng: ");
                    int ints = Convert.ToInt32(Console.ReadLine());
                    switch (ints)
                    {
                        case 1:
                            Console.WriteLine("Nhập mã học sinh: ");
                            string maHS = Console.ReadLine();
                            Console.WriteLine("Nhập tên học sinh: ");
                            string tenHS = Console.ReadLine();
                            Console.WriteLine("Nhập điểm toán: ");
                            int toan = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Nhập điểm văn: ");
                            int van = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Nhập điểm anh: ");
                            int anh = Convert.ToInt32(Console.ReadLine());
                            HocSinh hocSinh = new HocSinh(maHS, tenHS, toan, van, anh);
                            classroom.themHocSinh(hocSinh);
                            break;
                        case 2:
                            Console.WriteLine("Nhập tên học sinh cần tìm: ");
                            string name = Console.ReadLine();
                            classroom.timHocSinh(name); break;
                        case 3:
                            Console.WriteLine("Nhập tên học sinh cần cập nhật điểm: ");
                            string name2 = Console.ReadLine();
                            classroom.capNhatDiem(name2); break;
                        case 4:
                            Console.WriteLine("Nhập tên học sinh cần tính điểm trung bình: ");
                            string name3 = Console.ReadLine();
                            classroom.diemTBvaHocLuc(name3); break;
                        case 5:
                            Console.WriteLine("Nhập tên học sinh cần xóa: ");
                            string name5 = Console.ReadLine();
                            classroom.xoaHocSinh(name5); break;
                        case 6: classroom.xepLoai(); break;
                        case 7: classroom.hienThiTheoDiemTB(); break;
                        case 8: classroom.hienThiTheoTenHS(); break;
                        case 9:
                            classroom.ghiDuLieu();
                            classroom.docDuLieu();
                            break;
                        case 10:
                            //thoát
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter (1-10)");
                            break;
                    }
                }
            }
            else if (choice == 2)
            {
                KhoHang khoHang = new KhoHang("C02", "Dotnet02");
                while (true)
                {
                    Console.WriteLine("1. Thêm sản phẩm");
                    Console.WriteLine("2. Tìm sản phẩm");
                    Console.WriteLine("3. Câp nhật giá bán hoặc số lượng tồn kho");
                    Console.WriteLine("4. Tính tổng giá trị kho hàng");
                    Console.WriteLine("5. Xóa sản phẩm khỏi danh sách");
                    Console.WriteLine("6. Hiển thị danh sách học sinh và tổng giá trị");
                    Console.WriteLine("7. Sắp xếp sản phẩm theo giá bán tăng dần");
                    Console.WriteLine("8. Danh sách sản phẩm theo giá bán tăng dần");
                    Console.WriteLine("9. Sắp xếp sản phẩm theo tên");
                    Console.WriteLine("10. Danh sách sản phẩm theo tên");
                    Console.WriteLine("11. Ghi dữ liệu từ file json");
                    Console.WriteLine("12. Đọc dữ liệu từ file json");
                    Console.WriteLine("13. Thoát");
                    Console.WriteLine("Mời bạn chọn 1 chức năng: ");
                    int ints = Convert.ToInt32(Console.ReadLine());
                    switch (ints)
                    {
                        case 1:
                            Console.WriteLine("Nhập mã sản phẩm: ");
                            string maSP = Console.ReadLine();
                            Console.WriteLine("Nhập tên sản phẩm: ");
                            string tenSP = Console.ReadLine();
                            Console.WriteLine("Nhập giá bán sản phẩm: ");
                            double giaBan = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Nhập số lượng tồn kho: ");
                            int soLuong = Convert.ToInt32(Console.ReadLine());
                            SanPham sanPham = new SanPham(maSP, tenSP, giaBan, soLuong);
                            khoHang.themSP(sanPham);
                            break;
                        case 2:
                            Console.WriteLine("Nhập tên sản phẩm cần tìm: ");
                            string name2 = Console.ReadLine();
                            khoHang.timSP(name2);
                            break;
                        case 3:
                            Console.WriteLine("Mời nhập sản phẩm cần cập nhật: ");
                            string name3 = Console.ReadLine();
                            Console.WriteLine("Cập nhật: ");
                            Console.WriteLine("1. Giá trị sản phẩm");
                            Console.WriteLine("2. Số lượng sản phẩm");
                            int a = Convert.ToInt32(Console.ReadLine());
                            khoHang.capNhatGiaHoacSoLuong(name3, a);
                            break;
                        case 4:
                            Console.WriteLine("Nhập sản phẩm cần tính tổng giá trị: ");
                            string name4 = Console.ReadLine();
                            khoHang.tongGiaTriKho(name4);
                            break;
                        case 5:
                            Console.WriteLine("Nhập mã sản phẩm cần xóa: ");
                            string Id = Console.ReadLine();
                            khoHang.xoaSP(Id);
                            break;
                        case 6: khoHang.danhSachSPVaGiaTri(); break;
                        case 7: khoHang.sapXepSPTheoGiaBan(); break;
                        case 8: khoHang.hienThiTheoGiaBanTang(); break;
                        case 9: khoHang.sapXepTheoTenSP(); break;
                        case 10: khoHang.hienThiTheoTenSP(); break;
                        case 11: khoHang.ghiFileJson(); break;
                        case 12: khoHang.docFileJson(); break;
                        case 13: return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter (1-13)");
                            break;
                    }
                }
            }
        }
    }
}